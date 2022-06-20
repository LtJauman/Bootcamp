using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentEnrolmentWebApp.Models;

namespace StudentEnrolmentWebApp.Pages.StudentPage
{
    public class DetailsModel : PageModel
    {
        private readonly StudentEnrolmentWebApp.Models.StudentEnrolmentContext _context;

        public DetailsModel(StudentEnrolmentWebApp.Models.StudentEnrolmentContext context)
        {
            _context = context;
        }

        public Students Students { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Students = await _context.Student.FirstOrDefaultAsync(m => m.StudentId == id);

            if (Students == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
