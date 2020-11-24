using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rest.Controllers
{
    public class BaseController : ControllerBase
    {



        protected IActionResult TratarResultado(Func<IActionResult> servico)
        {
            try
            {
                return servico();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro genérico");
            }            
        }
    }
}
