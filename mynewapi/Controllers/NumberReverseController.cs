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
    public class NumberReverseController : ControllerBase
    {
        private readonly NumberReverseServices _numberReverseServices;
        public NumberReverseController(NumberReverseServices numberReverseServices)
        {

            _numberReverseServices = numberReverseServices;
        }

        [HttpGet]
        [Route("Fetch/Numbers")]
        public string GetReverse(string numbers)
        {
            return _numberReverseServices.GetReverse(numbers);
        }
    }
}