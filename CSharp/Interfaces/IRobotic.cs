using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCode
{
    public interface IRobotic
    {
        void Move(int steps);
        void Rotate(int degress);
        void SpinBeep(int spin, int beep);
    }
}
