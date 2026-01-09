using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mynewapi.Services;

namespace mynewapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MadLabController : ControllerBase
    {
        
        private readonly MadLabServices _madLabServices;

        public MadLabController(MadLabServices madLabServices)
        {
            _madLabServices = madLabServices; 
        }

        [HttpGet]
        [Route("Fetch/{Inputs}")] 
        public string GetInputs(string name, string place, string city, string noun, string adjective, string adverb, string animal, string sillyWord, string food, string otherfriends)
        {
          
            return _madLabServices.GetInputs(name,place,city,noun,adjective,adverb,animal,sillyWord,food,otherfriends);
        }
    }
}