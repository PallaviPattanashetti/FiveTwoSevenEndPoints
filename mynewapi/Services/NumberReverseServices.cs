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
        
        if (string.IsNullOrWhiteSpace(numbers) || !numbers.All(char.IsDigit))
        {
            return "Invalid input. Please enter numbers only.";
        }

        string reversed = "";
        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            reversed += numbers[i];
        }

        return $"You entered {numbers}, reversed is {reversed}";
    }
    }
}