using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;
using Edu.Application.DTO;

namespace Edu.Application.Services
{
    public interface IApplicationStudentRepository
    {
        Task<ApplicationStudent> GetById(int id);

        Task<ICollection<ApplicationStudent>> GetAll();

        Task<ApplicationStudent> Create(ApplicationStudent application);

        Task<ApplicationStudent> Update(int id, ApplicationStudent application);

        Task<ApplicationStudent> Delete(int id);
    }
}
