using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            Mapper.CreateMap<Genre, GenreDto>();
            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<Rental, RentalDto>();
            Mapper.CreateMap<CustomerDto, Customer>()
                .ForMember(c=>c.Id, opt =>opt.Ignore());
            Mapper.CreateMap<MovieDto, Movie>()
                .ForMember(c => c.Id, opt => opt.Ignore())
                .ForMember(c => c.NumberOfAvailable, opt => opt.Ignore()); 
        }
        

    }
}