﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp14.Core.Tasks
{
    public class Task1
    {
        public long Calculate(int n)
        {
            long result = 1;
            for(int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
