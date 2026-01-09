using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace mynewapi.Services
{
    public class ReverseItServices
    {
        public string GetSequence(string  inputs)
        {
            string reversed = "";
         
           
             for (int i = inputs.Length - 1; i >= 0; i--)
        {
            reversed += inputs[i];
        }

            return $"You entered {inputs}, reversed is {reversed}";
        }
    }
}