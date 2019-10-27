using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class CustomMath
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }

        public CustomMath(int num1, int num2)
        {
            Number1 = num1;
            Number2 = num2;
        }
        public int Add()
        {
            return Number1 + Number2;
        }
        public int Sub()
        {
            return Number1 - Number2;
        }
    }
}
