using System;

namespace PracticeCode
{
    class Program
    {
        static void Main(string[] args)
        {
            ChessChecker chessChecker = new ChessChecker();

            var validPositions = chessChecker.ValidKnightPositions('b', 2);

            foreach (var postition in validPositions)
            {
                Console.WriteLine(postition);
            }
        }

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
