using AutoMapperexapem.InterfaceRepository;
using AutoMapperexapem.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AutoMapperexapem.Controllers
{
    [RoutePrefix("api/users")]
    public class UsersController : ApiController
    {
        private IUsersRepository _usersRepository;
        public UsersController(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        [Route("GetAllUsers")]
        [HttpGet]
        public IHttpActionResult Get()
        {

            return Json(_usersRepository.GetAllUsers());
        }

        [HttpGet]
        [Route("GetUsersByUserName/{UserName}")]
        public HttpResponseMessage GetUserByUserName(string userName)
        {
            var user = _usersRepository.GetUserByUserName(userName);
            if (user != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, user);
            }
            return Request.CreateErrorResponse(HttpStatusCode.NotFound, $"The provided username : {userName} does not exist");
        }
    }
}
