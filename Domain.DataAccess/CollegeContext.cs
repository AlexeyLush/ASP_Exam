using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace Domain.DataAccess
{
    public class CollegeContext: DbContext
    {
        public virtual DbSet<ApplicationStudent> ApplicationStudents { get; set; }
        public CollegeContext()
        {

        }
        public CollegeContext(DbContextOptions<CollegeContext> options) : base(options)
        {

        }
    }
}
