using Edu.Application.DTO;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edu.Api.App.ApplicationStudent.Commands.Delete
{
    public class DeleteApplicationStudentRequest: IRequest<ApplicationStudentDTO>
    {
        public int ApplicationStudentId { get; }

        public DeleteApplicationStudentRequest(int id)
        {
            ApplicationStudentId = id;
        }
    }
}
