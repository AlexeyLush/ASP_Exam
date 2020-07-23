using Domain.Model;
using Edu.Application.DTO;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edu.Api.App.ApplicationStudent.Commands.Create
{
    public class CreateApplicationStudentCommand : IRequest<ApplicationStudentDTO>
    {
        public int Id { get; set; }
        public string IIN { get; set; }
        public int Score { get; set; }
        public Profile ProfileFirst { get; set; }
        public Profile ProfileSecond { get; set; }
        public College College { get; set; }
    }
}
