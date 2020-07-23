using AutoMapper;
using Edu.Application.DTO;
using Edu.Application.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Edu.Api.App.ApplicationStudent.Commands.Create
{
    public class CreateApplicationStudentRequestHandler: IRequestHandler<CreateApplicationStudentCommand, ApplicationStudentDTO>
    {
        private readonly IApplicationStudentRepository _applicationStudentRepository;
        private readonly IMapper _mapper;


        public CreateApplicationStudentRequestHandler(IApplicationStudentRepository applicationStudentRepository, IMapper mapper)
        {
            _applicationStudentRepository = applicationStudentRepository;
            _mapper = mapper;
        }

        public async Task<ApplicationStudentDTO> Handle(CreateApplicationStudentCommand request, CancellationToken cancellationToken)
        {
            var newApplicationStudent = new Domain.Model.ApplicationStudent()
            {
                Id = request.Id,
                College = request.College,
                IIN = request.IIN,
                ProfileFirst = request.ProfileFirst,
                ProfileSecond = request.ProfileSecond,
                Score = request.Score
            };
            await _applicationStudentRepository.Create(newApplicationStudent);;
            return _mapper.Map<ApplicationStudentDTO>(request);
        }
    }
}
