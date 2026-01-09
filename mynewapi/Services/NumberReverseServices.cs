using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mynewapi.Services
{
    public class NumberReverseServices
    {
        public string GetReverse(string numbers)
        {
            string reversed = "";
            for (int i = numbers.Length - 1; i >= 0; i--)
        {
            reversed += numbers[i];
        }

        return $"You entered {numbers}, reversed is {reversed}";
        

        }
    }
}