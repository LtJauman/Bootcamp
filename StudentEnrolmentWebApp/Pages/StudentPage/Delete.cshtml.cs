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
    public class DeleteModel : PageModel
    {
        private readonly StudentEnrolmentWebApp.Models.StudentEnrolmentContext _context;

        public DeleteModel(StudentEnrolmentWebApp.Models.StudentEnrolmentContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Students = await _context.Student.FindAsync(id);

            if (Students != null)
            {
                _context.Student.Remove(Students);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
