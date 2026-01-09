using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mynewapi.Services;

namespace mynewapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OddOrEvenController : ControllerBase
    {
        private readonly OddOrEvenServices _oddOrEvenServices;
        public OddOrEvenController(OddOrEvenServices oddOrEvenServices)
        {
            
            _oddOrEvenServices = oddOrEvenServices;
        }
        [HttpGet]
        [Route("Fetch/{number}")]

        public string GetNumber(int number)
        {
            
            return _oddOrEvenServices.CheckOddOrEven(number);
        }
    }
}