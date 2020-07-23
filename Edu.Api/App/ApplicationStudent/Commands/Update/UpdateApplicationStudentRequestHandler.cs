using AutoMapper;
using Edu.Application.DTO;
using Edu.Application.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Edu.Api.App.ApplicationStudent.Commands.Update
{
    public class UpdateApplicationStudentRequestHandler : IRequestHandler<UpdateApplicationStudentRequest, ApplicationStudentDTO>
    {
        private readonly IApplicationStudentRepository _applicationStudentRepository;
        private readonly IMapper _mapper;

        public UpdateApplicationStudentRequestHandler(IApplicationStudentRepository applicationStudentRepository, IMapper mapper)
        {
            _applicationStudentRepository = applicationStudentRepository;
            _mapper = mapper;
        }

        public async Task<ApplicationStudentDTO> Handle(UpdateApplicationStudentRequest request, CancellationToken cancellationToken)
        {
            var updateApplicationStudent = new Domain.Model.ApplicationStudent()
            {
                Id = request.Command.Id,
                College = request.Command.College,
                IIN = request.Command.IIN,
                ProfileFirst = request.Command.ProfileFirst,
                ProfileSecond = request.Command.ProfileSecond,
                Score = request.Command.Score
            };
            var applicationStudent = await _applicationStudentRepository.Update(request.ApplicationStudentId, updateApplicationStudent);
            return _mapper.Map<ApplicationStudentDTO>(request.Command);
        }
    }
}
