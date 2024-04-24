using AutoMapper;
using AgroPalace31.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgroPalace31.Profiles
{
    public class CoursesProfile : Profile
    {
        public CoursesProfile()
        {
            CreateMap<CourseLibrary.API.Entities.Course, Model.CourseDto>();
            CreateMap<Model.CourseForCreationDto, CourseLibrary.API.Entities.Course>();
        }
    }
}
