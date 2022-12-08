
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CIDM3312_FinalProject.Models;

namespace CIDM3312_FinalProject.Pages;

public class FacilityListDetailedModel : PageModel
{
    private readonly ProjectDbContext _context;
    
    public FacilityListDetailedModel(ProjectDbContext context)
    {
        _context = context;
    }

    public IList<Facility> Facility {get; set;} = default!;

    public async Task OnGetAsync()
    {
        if (_context.Facilities != null)
        {
            Facility = await _context.Facilities.Include(f => f.FacilityCollections!).ThenInclude(fc => fc.CollectionLayer).ToListAsync();
        }
    }
}