using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Vidly_MVC.Dtos;
using Vidly_MVC.Models;

namespace Vidly_MVC.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();

            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<MovieDto, Movie>();
        }
    }
}