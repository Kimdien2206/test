using System;
using System.Collections.Generic;
using System.Text;

namespace BT2
{
    class MathSpecial : Student
    {
        public override float AveragePoint()
        {
            return (EngPoint + LitPoint + MathPoint * 2) / 4;
        }
    }

}
