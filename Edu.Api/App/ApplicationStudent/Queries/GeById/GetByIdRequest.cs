using Edu.Application.DTO;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edu.Api.App.ApplicationStudent.Queries.GeById
{
    public class GetByIdRequest: IRequest<ApplicationStudentDTO>
    {
        public int ApplicationStudentId { get; set; }
        public GetByIdRequest(int id)
        {
            ApplicationStudentId = id;
        }
    }
}
