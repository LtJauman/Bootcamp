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
    public class IndexModel : PageModel
    {
        private readonly StudentEnrolmentWebApp.Models.StudentEnrolmentContext _context;

        public IndexModel(StudentEnrolmentWebApp.Models.StudentEnrolmentContext context)
        {
            _context = context;
        }

        public IList<Students> Students { get;set; }

        public async Task OnGetAsync()
        {
            Students = await _context.Student.ToListAsync();
        }
    }
}
