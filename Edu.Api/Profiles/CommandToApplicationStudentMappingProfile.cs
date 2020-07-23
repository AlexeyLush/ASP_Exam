using AutoMapper;
using Edu.Api.App.ApplicationStudent.Commands.Create;
using Edu.Api.App.ApplicationStudent.Commands.Update;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edu.Api.Profiles
{
    public class CommandToApplicationStudentMappingProfile: Profile
    {
        public CommandToApplicationStudentMappingProfile()
        {
            CreateMap<CreateApplicationStudentCommand, Domain.Model.ApplicationStudent>();
            CreateMap<UpdateApplicationStudentCommand, Domain.Model.ApplicationStudent>();
        }
    }
}
