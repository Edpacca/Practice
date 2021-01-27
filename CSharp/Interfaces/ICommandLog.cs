using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCode
{
    public interface ICommandLog
    {
        List<string> CommandLog { get; set; }
        void Log(string command, List<int> values);
    }
}
