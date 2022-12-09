
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CIDM3312_FinalProject.Models;

namespace CIDM3312_FinalProject.Pages;

public class LayerListBriefModel : PageModel
{
    private readonly ProjectDbContext _context;
    
    public LayerListBriefModel(ProjectDbContext context)
    {
        _context = context;
    }

    public IList<CollectionLayer> CollectionLayer {get; set;} = default!;

    // PageNum is the current page number we are on
    // PageSize is how many records will be displayed per page. 
    // SupportsGet = true allows us to pass the PageNum through the URL with an HTTP Get Parameter 
    // This is necessary, because page numbers are not passed through normal forms
    [BindProperty(SupportsGet = true)]
    public int PageNum {get; set;} = 1;
    public int PageSize {get; set;} = 10;


        // Sorting support
        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;} = string.Empty;
        // Second sorting technique with a SelectList
        public SelectList SortList {get; set;} = default!;

    public async Task OnGetAsync()
    {
        if (_context.Facilities != null)
        {
            var query = _context.CollectionLayers.Select(cl => cl);
                List<SelectListItem> sortItems = new List<SelectListItem> {
                    new SelectListItem { Text = "Layer Label Ascending", Value = "ll_asc" },
                    new SelectListItem { Text = "Layer Label Descending", Value = "ll_desc"}
                };
                SortList = new SelectList(sortItems, "Value", "Text", CurrentSort);

                switch (CurrentSort)
                {
                    // If user selected "first_asc", modify query to sort by first name ascending order
                    case "first_asc": 
                        query = query.OrderBy(p => p.FirstName);
                        break;
                    // If user selected "first_desc", modify query to sort by first name descending
                    case "first_desc":
                        query = query.OrderByDescending(p => p.FirstName);
                        break;
                    // Add more sorting cases as needed
                }

            CollectionLayer = await query.Include(cl => cl.FacilityCollections!).ThenInclude(fc => fc.Facility).Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
        }
    }
}