using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationWebAPI.Domain.Models;
using WebApplicationWebAPI.Resources;

namespace WebApplicationWebAPI.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
    {
        CreateMap<SaveCategoryResource, Category>();
    }
}
}
