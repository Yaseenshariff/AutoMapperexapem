using AutoMapperexapem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperexapem.InterfaceRepository
{
    public interface IUsersRepository
    {
        List<UsersDTO> GetAllUsers();
        UsersDTO GetUserByUserName(string userName);
    }
}
