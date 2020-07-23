using AutoMapper;
using Edu.Api.App.ApplicationStudent.Commands.Create;
using Edu.Api.App.ApplicationStudent.Commands.Update;
using Edu.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edu.Api.Profiles
{
    public class CommandToDTO: Profile
    {
        public CommandToDTO()
        {
            CreateMap<CreateApplicationStudentCommand, ApplicationStudentDTO>();
            CreateMap<UpdateApplicationStudentCommand, ApplicationStudentDTO>();
        }
    }
}
