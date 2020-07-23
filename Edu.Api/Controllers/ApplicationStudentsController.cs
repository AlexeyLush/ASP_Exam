using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Domain.DataAccess;
using Domain.Model;
using MediatR;
using System.Threading;
using Edu.Application.DTO;
using Edu.Api.App.ApplicationStudent.Queries.GeById;
using Edu.Api.App.ApplicationStudent.Commands.Update;
using Edu.Api.App.ApplicationStudent.Commands.Create;
using Edu.Api.App.ApplicationStudent.Commands.Delete;

namespace Edu.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationStudentsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ApplicationStudentsController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<ApplicationStudentDTO>> GetApplicationStudent(int id, CancellationToken ct)
        {
            var request = new GetByIdRequest(id);
            var response = await _mediator.Send(request);

            return response;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutApplicationStudent(int id, UpdateApplicationStudentCommand command)
        {
            var request = new UpdateApplicationStudentRequest(id, command);
            var response = await _mediator.Send(request);

            return Ok(response);


        }

        [HttpPost]
        public async Task<ActionResult<ApplicationStudentDTO>> PostApplicationStudent(CreateApplicationStudentCommand command)
        {
            var response = await _mediator.Send(command);
            return response;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ApplicationStudentDTO>> DeleteApplicationStudent(int id)
        {
            var request = new DeleteApplicationStudentRequest(id);
            var response = await _mediator.Send(request);
            return response;

        }
    }
}
