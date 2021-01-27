using System;

namespace PracticeCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var robot = new BillyRobot();

            robot.SpinBeep(3, 7);
            robot.Move(21);
            robot.Rotate(2);
            robot.Move(2);
            robot.SpinBeep(23, 1);

            foreach (var command in robot.CommandLog)
            {
                Console.WriteLine(command);
            }
        }
    }
}
