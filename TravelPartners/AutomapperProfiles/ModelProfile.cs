using System;
using System.Collections.Generic;
using AutoMapper;
using TravelPartners.Models;
using TravelPartners.Repositories.Entities;

namespace TravelPartners.AutomapperProfiles
{
    internal sealed class ModelProfile : Profile
    {
        public ModelProfile()
        {
            CreateMap<UserRequestModel, UserEntity>(MemberList.Destination)
                .ForMember(dest => dest.Id, opts => opts.MapFrom(src => Guid.NewGuid()));
            CreateMap<UserEntity, UserResponseModel>(MemberList.Destination);
            CreateMap<List<UserEntity>, List<UserResponseModel>>();
        }
    }
}