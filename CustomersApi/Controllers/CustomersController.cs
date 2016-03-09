using CustomersApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CustomersApi.Controllers
{
    public class CustomersController : ApiController
    {
        public IHttpActionResult Get()
        {
            IList<Customer> customers = new List<Customer>
            {
                new Customer { Name = "Simon", Address = "Tideswell", Telephone = "01298 888777" },
                new Customer { Name = "Rachel", Address = "Tideswell", Telephone = "01298 444000" }
            };
            return Ok<IList<Customer>>(customers);            
        }
    }
}
