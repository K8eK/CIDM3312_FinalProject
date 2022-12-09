
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CIDM3312_FinalProject.Models;

namespace CIDM3312_FinalProject.Pages;

public class LayerListDetailedModel : PageModel
{
    private readonly ProjectDbContext _context;
    
    public LayerListDetailedModel(ProjectDbContext context)
    {
        _context = context;
    }

    public IList<CollectionLayer> CollectionLayer {get; set;} = default!;

    public async Task OnGetAsync()
    {
        if (_context.CollectionLayers != null)
        {
            CollectionLayer = await _context.CollectionLayers.Include(cl => cl.FacilityCollections!).ThenInclude(fc => fc.FacilityId).ToListAsync();
        }
    }
}