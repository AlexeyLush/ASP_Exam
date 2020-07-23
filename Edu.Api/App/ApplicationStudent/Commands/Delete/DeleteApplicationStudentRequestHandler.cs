using AutoMapper;
using Edu.Application.DTO;
using Edu.Application.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Edu.Api.App.ApplicationStudent.Commands.Delete
{
    public class DeleteApplicationStudentRequestHandler: IRequestHandler<DeleteApplicationStudentRequest, ApplicationStudentDTO>
    {
        private readonly IApplicationStudentRepository _applicationStudentRepository;
        private readonly IMapper _mapper;

        public DeleteApplicationStudentRequestHandler(IApplicationStudentRepository applicationStudentRepository, IMapper mapper)
        {
            _applicationStudentRepository = applicationStudentRepository;
            _mapper = mapper;
        }

        public async Task<ApplicationStudentDTO> Handle(DeleteApplicationStudentRequest request, CancellationToken cancellationToken)
        {
            var applicationStudent = await _applicationStudentRepository.Delete(request.ApplicationStudentId);
            return _mapper.Map<ApplicationStudentDTO>(request);
        }
    }
}
