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
    public class ReverseItController : ControllerBase
    {
        private readonly ReverseItServices _reverseItServices;
        private ReverseItServices reverseItServices;

        public ReverseItController(ReverseItServices reverseItServices)
        {
            
            _reverseItServices = reverseItServices;
        }
        [HttpGet]
        [Route("Fetch/NumbersAndLetters")]
        public string GetSequence(string inputs)
        {
           return _reverseItServices.GetSequence(inputs);
        }
    }
}