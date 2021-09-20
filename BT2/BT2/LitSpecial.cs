using System;
using System.Collections.Generic;
using System.Text;

namespace BT2
{
    class LitSpecial : Student
    {
        public override float AveragePoint()
        {
            return (EngPoint + LitPoint * 2 + MathPoint);
        }
    }
}
