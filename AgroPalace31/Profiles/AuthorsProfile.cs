using AgroPalace31.Helper;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgroPalace31.Profiles
{
    public class AuthorsProfile : Profile
    {
        public AuthorsProfile()
        {
            CreateMap<CourseLibrary.API.Entities.Author, Model.AuthorDto>()
                .ForMember(
                dest => dest.Name,
                opt => opt.MapFrom(src => $"{ src.FirstName}{ src.LastName}"))
                .ForMember(
                dest => dest.Age,
                opt => opt.MapFrom(src => src.DateOfBirth.GetCurrentAge()));
        }
    }
}
