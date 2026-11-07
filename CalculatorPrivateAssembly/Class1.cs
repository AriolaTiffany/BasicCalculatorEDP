using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorPrivateAssembly
{
    public class BasicComputation
    {
        public static float Addition(float FirstNum, float SecondNum)
        { 
            return FirstNum + SecondNum;
        }

        public static float Subtraction(float FirstNum, float SecondNum)
        {
            return FirstNum - SecondNum;
        }

        public static float Multiplication(float FirstNum, float SecondNum)
        {
            return FirstNum * SecondNum;
        }

        public static float Division(float FirstNum, float SecondNum)
        {
            return FirstNum / SecondNum;
        }

    }
}
