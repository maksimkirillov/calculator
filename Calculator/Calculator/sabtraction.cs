﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
   public class sabtraction : ICalculateTwoArguments
    {
        public double Calculator(double firstArgument, double secondArgument)
        {
            return firstArgument - secondArgument;
        }
    }
}
