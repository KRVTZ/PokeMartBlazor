using AutoMapper;
using Mart_DataAccess;
using Mart_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mart_Business.Mapper
{
    public class MappingProfile : Profile
    {   
        public MappingProfile()
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
        }
    }
}
