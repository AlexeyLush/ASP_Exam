using AutoMapper;
using Edu.Application.DTO;
using Edu.Application.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Edu.Api.App.ApplicationStudent.Queries.GeById
{
    public class GetByIdRequestHandler : IRequestHandler<GetByIdRequest, ApplicationStudentDTO>
    {
        private readonly IApplicationStudentRepository _applicationStudentRepository;
        private readonly IMapper _mapper;

        public GetByIdRequestHandler(IApplicationStudentRepository applicationStudentRepository, IMapper mapper)
        {
            _applicationStudentRepository = applicationStudentRepository;
            _mapper = mapper;
        }

        public async Task<ApplicationStudentDTO> Handle(GetByIdRequest request, CancellationToken cancellationToken)
        {
            var applicationStudent = await _applicationStudentRepository.GetById(request.ApplicationStudentId);
            return _mapper.Map<ApplicationStudentDTO>(applicationStudent);
        }
    }
}
