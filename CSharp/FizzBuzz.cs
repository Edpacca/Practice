using System;

namespace PracticeCode
{
    class FizzBuzz
    {
        int fizzMultiple = 3;
        int buzzMultiple = 5;
        string fizzMessage = "Fizz";
        string buzzMessage = "Buzz";
        int countTo = 100;
        bool isMultiple = false;


        public void FizzBuzzer()
        {
            for (int i = 1; i <= countTo; i++)
            {
                if (i % fizzMultiple == 0)
                {
                    Console.Write(fizzMessage);
                    isMultiple = true;
                }

                if (i % buzzMultiple == 0)
                {
                    Console.Write(buzzMessage);
                    isMultiple = true;
                }

                if (!isMultiple)
                    Console.Write(i);

                isMultiple = false;
                Console.WriteLine("");
            }
        }
    }
}
