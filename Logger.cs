﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    internal class Logger
    {
        public static void Log(string msg)
        {
            Console.WriteLine(msg + " " + DateTime.Now);
        }
    }
}
