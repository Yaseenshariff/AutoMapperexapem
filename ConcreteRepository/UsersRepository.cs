using AutoMapper;
using AutoMapperexapem.InterfaceRepository;
using AutoMapperexapem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoMapperexapem.ConcreteRepository
{
    public class UsersRepository : IUsersRepository
    {
        public List<UsersDTO> GetAllUsers()
        {
            List<User> users;
            using (var data = new Customer_DataEntities())
            {
                users = data.Users.ToList();
            }
            return Mapper.Map<List<UsersDTO>>(users);
        }

        public UsersDTO GetUserByUserName(string userName)
        {
            using(var data = new Customer_DataEntities())
            {
                User user =  data.Users.FirstOrDefault(x => x.UserName == userName);
                return Mapper.Map<UsersDTO>(user);
            }
        }
    }
}