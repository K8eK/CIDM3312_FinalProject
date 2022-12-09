
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CIDM3312_FinalProject.Models;

namespace CIDM3312_FinalProject.Pages
{
    public class EditKnownFacilityModel : PageModel
    {
        private readonly ILogger<EditKnownFacilityModel> _logger;
        private readonly ProjectDbContext _context;

        public EditKnownFacilityModel(ProjectDbContext context, ILogger<EditKnownFacilityModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        [BindProperty]
        public Facility Facility { get; set; } = default!; // The selected facility
        public List<CollectionLayer> CollectionLayers {get; set;} = default!; // All layers

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Facilities == null)
            {
                return NotFound();
            }

            // Bring in related data using Include and ThenInclude
            var KnownFacility =  await _context.Facilities.Include(f => f.FacilityCollections!).ThenInclude(fc => fc.CollectionLayer).FirstOrDefaultAsync(m => m.FacilityId == id);
            // Get a list of all courses. This list is used to make the checkboxes
            CollectionLayers = _context.CollectionLayers.ToList();
            if (KnownFacility == null)
            {
                return NotFound();
            }
            Facility = KnownFacility;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(int[] SelectedLayers)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Find the target row you want to update and update non-key values
            var FacilityToUpdate = await _context.Facilities.Include(f => f.FacilityCollections!).ThenInclude(fc => fc.CollectionLayer).FirstOrDefaultAsync(m => m.FacilityId == Facility.FacilityId);
            if (FacilityToUpdate != null) 
            {
                FacilityToUpdate.FacilityCode = Facility.FacilityCode;
                FacilityToUpdate.FacilityName = Facility.FacilityName;
                
                // Separate method to update the courses because it can get complex
                UpdateFacilityCollections(SelectedLayers, FacilityToUpdate);
            }

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FacilityExists(Facility.FacilityId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool FacilityExists(int id)
        {
          return _context.Facilities.Any(fe => fe.FacilityId == id);
        }

        private void UpdateFacilityCollections(int[] SelectedLayers, Facility FacilityToUpdate)
        {
            if (SelectedLayers == null)
            {
                FacilityToUpdate.FacilityCollections = new List<FacilityCollection>();
                return;
            }

            List<int> CurrentLayers = FacilityToUpdate.FacilityCollections!.Select(c => c.CollectionLayerId).ToList();
            List<int> SelectedLayersList = SelectedLayers.ToList();

            foreach (var Layer in _context.CollectionLayers)
            {
                if (SelectedLayersList.Contains(Layer.CollectionLayerId))
                {
                    if (!CurrentLayers.Contains(Layer.CollectionLayerId))
                    {
                        // Add CollectionLayer here
                        FacilityToUpdate.FacilityCollections!.Add(
                            new FacilityCollection { FacilityId = FacilityToUpdate.FacilityId, CollectionLayerId = Layer.CollectionLayerId }
                        );
                        _logger.LogWarning($"Facility {FacilityToUpdate.FacilityName} - ADD {Layer.CollectionLayerId} {Layer.CollectionLabel}");
                    }
                }
                else
                {
                    if (CurrentLayers.Contains(Layer.CollectionLayerId))
                    {
                        // Remove collectionlayer here
                        FacilityCollection LayerToRemove = FacilityToUpdate.FacilityCollections!.SingleOrDefault(f => f.CollectionLayerId == Layer.CollectionLayerId)!;
                        _context.Remove(LayerToRemove);
                        _logger.LogWarning($"Student {FacilityToUpdate.FacilityName} - DROP {Layer.CollectionLayerId} {Layer.CollectionLabel}");
                    }
                }
            }
        }
    }
}
