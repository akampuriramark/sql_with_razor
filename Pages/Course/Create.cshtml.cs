#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TutorialEUSchool.Data;
using TutorialEUSchool.Entities;

namespace TutorialEUSchool.Pages.Course
{
    public class CreateModel : PageModel
    {
        private readonly TutorialEUSchool.Data.TutorialEUSchoolContext _context;

        public CreateModel(TutorialEUSchool.Data.TutorialEUSchoolContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public TutorialEUSchool.Entities.Course Course { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Course.Add(Course);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
