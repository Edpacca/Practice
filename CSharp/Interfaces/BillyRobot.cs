using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCode
{
    public class BillyRobot : IRobotic, ICommandLog
    {
        public List<string> CommandLog { get; set; }

        public BillyRobot()
        {
            CommandLog = new List<string>();
        }

        public void SpinBeep(int spin, int beep)
        {
            Console.WriteLine("spun {0} times, beeped {1} times", spin, beep);
            Log("Spin/Beep", new List<int>() { spin, beep });
        }

        public void Move(int steps)
        {
            Console.WriteLine("took {0} steps", steps);
            Log("Move", new List<int>() { steps });
        }

        public void Rotate(int degress)
        {
            Console.WriteLine("rotated {0} degrees", degress);
            Log("Rotate", new List<int>() { degress });
        }

        public void Log(string command, List<int> values)
        {
            string fullCommand = command + ":";

            foreach (var value in values)
            {
                fullCommand = fullCommand + " " + value + ",";
            }

            CommandLog.Add(fullCommand);
        }
    }
}
