using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCode
{
    class SimpleCode
    {
        public static int UserInputToInteger(string message)
        {
            string userInput;
            int output;

            do
            {
                Console.Write(message);
                userInput = Console.ReadLine();
            }
            while (!int.TryParse(userInput, out output));

            return output;
        }
    }
}
