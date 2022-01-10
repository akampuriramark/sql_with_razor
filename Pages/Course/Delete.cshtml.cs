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
    public class DeleteModel : PageModel
    {
        private readonly TutorialEUSchool.Data.TutorialEUSchoolContext _context;

        public DeleteModel(TutorialEUSchool.Data.TutorialEUSchoolContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Course = await _context.Course.FindAsync(id);

            if (Course != null)
            {
                _context.Course.Remove(Course);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
