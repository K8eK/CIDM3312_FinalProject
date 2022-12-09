
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

    public async Task OnGetAsync()
    {
        if (_context.Facilities != null)
        {
            var query = _context.CollectionLayers.Select(cl => cl);

                switch (CurrentSort)
                {
                    // Modify query to sort by ascending order
                    case "cl_asc": 
                        query = query.OrderBy(cl => cl.CollectionLabel);
                        break;
                    //Modify query to sort by descending order
                    case "cl_desc":
                        query = query.OrderByDescending(cl => cl.CollectionLabel);
                        break;
                    // Modify query to sort by ascending order
                    case "cc_asc":
                        query = query.OrderBy(cl => cl.CollectionCode);
                        break;
                    //Modify query to sort by descending order
                    case "cc_desc":
                        query = query.OrderByDescending(cl => cl.CollectionCode);
                        break;
                }

            CollectionLayer = await query.Include(cl => cl.FacilityCollections!).ThenInclude(fc => fc.Facility).Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
        }
    }
}