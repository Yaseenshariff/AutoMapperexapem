using AutoMapper;
using AutoMapperexapem.InterfaceRepository;
using AutoMapperexapem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AutoMapperexapem.Controllers
{
    public class ValuesController : ApiController
    {
        private IUsersRepository _usersRepository;
        public ValuesController(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }
        // GET api/values
        //public List<ConcertDTO> Get()
        //{
        //    return _usersRepository.GetAllConcerts();
        //}

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
