using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication4
{
    public class CustomerController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Customer> Get()
        {
            return new Customer[] { new Customer() { Name = "Test" } };
        }
    }
}