using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Rest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : BaseController
    {

        [HttpGet]
        public IActionResult Get() => TratarResultado(() => {
            List<Customer> lista = new List<Customer>();

            lista.Add(new Customer() { Id = 1, Name = "Maria" });
            lista.Add(new Customer() { Id = 2, Name = "Antônio" });
            lista.Add(new Customer() { Id = 3, Name = "João" });

            return new ObjectResult(lista) { StatusCode = StatusCodes.Status200OK };
        });

        [HttpPost]
        public IActionResult Set([FromBody] Customer request) => TratarResultado(() => {

            Console.WriteLine($"Id: {request.Id} ----- Name: {request.Name}");

            return new ObjectResult(new object()) { StatusCode = StatusCodes.Status201Created };

        });
    }
}
