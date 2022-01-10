#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TutorialEUSchool.Entities;

namespace TutorialEUSchool.Data
{
    public class TutorialEUSchoolContext : DbContext
    {
        public TutorialEUSchoolContext (DbContextOptions<TutorialEUSchoolContext> options)
            : base(options)
        {
        }

        public DbSet<TutorialEUSchool.Entities.Course> Course { get; set; }
    }
}
