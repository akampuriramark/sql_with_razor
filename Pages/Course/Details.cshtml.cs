#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TutorialEUSchool.Data;
using TutorialEUSchool.Entities;

namespace TutorialEUSchool.Pages.Course
{
    public class DetailsModel : PageModel
    {
        private readonly TutorialEUSchool.Data.TutorialEUSchoolContext _context;

        public DetailsModel(TutorialEUSchool.Data.TutorialEUSchoolContext context)
        {
            _context = context;
        }

        public TutorialEUSchool.Entities.Course Course { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Course = await _context.Course.FirstOrDefaultAsync(m => m.CourseID == id);

            if (Course == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
