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
    public class IndexModel : PageModel
    {
        private readonly TutorialEUSchool.Data.TutorialEUSchoolContext _context;

        public IndexModel(TutorialEUSchool.Data.TutorialEUSchoolContext context)
        {
            _context = context;
        }

        public IList<TutorialEUSchool.Entities.Course> Course { get;set; }

        public async Task OnGetAsync()
        {
            Course = await _context.Course.ToListAsync();
        }
    }
}
