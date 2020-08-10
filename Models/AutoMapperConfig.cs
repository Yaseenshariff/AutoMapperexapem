using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoMapperexapem.Models
{
    public class AutoMapperConfig
    {
        public static void Initialize()
        {
            Mapper.Initialize((config) =>
            {
                config.CreateMap<UsersDTO, User>();
                config.CreateMap<User, UsersDTO>();
            });
        }
    }
}