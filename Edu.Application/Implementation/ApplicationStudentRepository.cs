using Domain.DataAccess;
using Domain.Model;
using Edu.Application.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.Application.Implementation
{
    public class ApplicationStudentRepository: IApplicationStudentRepository
    {
        private readonly CollegeContext _context;

        public ApplicationStudentRepository(CollegeContext context)
        {
            _context = context;
        }

        public async Task<ApplicationStudent> Create(ApplicationStudent application1)
        {
            var createdClass = await _context.ApplicationStudents.AddAsync(application1);
            await _context.SaveChangesAsync();

            return createdClass.Entity;
        }

        public async Task<ApplicationStudent> Delete(int id)
        {
            var application1ToDelete = await GetById(id);

            if (application1ToDelete == null) return null;

            _context.ApplicationStudents.Remove(application1ToDelete);
            await _context.SaveChangesAsync();

            return application1ToDelete;
        }

        public async Task<ICollection<ApplicationStudent>> GetAll()
        {
            return await _context.ApplicationStudents.ToListAsync();
        }

        public async Task<ApplicationStudent> GetById(int id)
        {
            return await _context.ApplicationStudents.FindAsync(id);
        }

        public async Task<ApplicationStudent> Update(int id, ApplicationStudent application1)
        {
            var applicationToUpdate = await GetById(id);
            if (applicationToUpdate == null) return null;

            applicationToUpdate = application1;

            _context.ApplicationStudents.Update(application1);


            await _context.SaveChangesAsync();

            return applicationToUpdate;
        }
    }
}
