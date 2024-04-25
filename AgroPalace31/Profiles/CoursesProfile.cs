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
            //creating resource
            CreateMap<Model.CourseForCreationDto, CourseLibrary.API.Entities.Course>();
            //updating a resource
            CreateMap<Model.CourseForUpdateDto, CourseLibrary.API.Entities.Course>();
        }
    }
}
