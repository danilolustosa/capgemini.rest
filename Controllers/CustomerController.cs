using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Rest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController
    {

        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            List<Customer> lista = new List<Customer>();

            lista.Add(new Customer() { Id = 1, Name = "Maria" });
            lista.Add(new Customer() { Id = 2, Name = "Antônio" });
            lista.Add(new Customer() { Id = 3, Name = "João" });

            return lista;
        }

        [HttpPost]
        public void Set([FromBody] Customer request)
        {
            Console.WriteLine($"Id: {request.Id} ----- Name: {request.Name}");
        }
    }
}
