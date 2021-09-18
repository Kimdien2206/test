using System;
using System.Collections.Generic;
using System.Text;

namespace BT2
{
    class EngSpecial : Student
    {
        public override float AveragePoint()
        {
            return (EngPoint * 2 + LitPoint + MathPoint) / 4;
        }
    }
}
