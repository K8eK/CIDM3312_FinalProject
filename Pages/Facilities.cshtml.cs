
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CIDM3312_FinalProject.Models;

namespace CIDM3312_FinalProject.Pages;

public class FacilitiesModel : PageModel
{
    private readonly ProjectDbContext _context;
    
    public FacilitiesModel(ProjectDbContext context)
    {
        _context = context;
    }

    public void OnGet()
    {
    }
}