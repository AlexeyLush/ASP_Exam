using Edu.Application.DTO;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edu.Api.App.ApplicationStudent.Commands.Update
{
    public class UpdateApplicationStudentRequest: IRequest<ApplicationStudentDTO>
    {
        public int ApplicationStudentId { get; set; }
        public UpdateApplicationStudentCommand Command { get; set; }

        public UpdateApplicationStudentRequest(int id, UpdateApplicationStudentCommand command)
        {
            ApplicationStudentId = id;
            Command = command;
        }
    }
}
