using AspNetSeed.Service;
using AspNetSeed.Domain;
using AspNetSeed.Web.Models;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AspNetSeed.Web.Controllers.Api
{
    public class CustomerController : ApiController
    {
        [Inject]
        public IUserService UserService { get; set; }

        // GET: api/Customer
        public IEnumerable<CustomerViewModel> Get()
        {
            List<CustomerViewModel> usersModel = new List<CustomerViewModel>();

            List<User> usersDto = UserService.GetUsers().ToList();

            usersDto.ForEach(u => usersModel.Add(new CustomerViewModel(u.Id, u.FirstName)));

            return usersModel;
        }

        // GET: api/Customer/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Customer
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Customer/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Customer/5
        public void Delete(int id)
        {
        }
    }
}
