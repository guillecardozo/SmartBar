using AutoMapper;
using Entities.Models;
using Shared.DTOs;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace SmartBar.API
{
    public class MappingProfile: Profile
    {
        public MappingProfile() 
        {
            CreateMap<Producto, ProductoDTO>();
        }
    }
}
