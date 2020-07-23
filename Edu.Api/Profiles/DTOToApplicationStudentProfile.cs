using AutoMapper;
using Edu.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edu.Api.Profiles
{
    public class DTOToApplicationStudentProfile: Profile
    {
        public DTOToApplicationStudentProfile()
        {
            CreateMap<Domain.Model.ApplicationStudent, ApplicationStudentDTO>();
        }
    }
}
