﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebhookTestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass tc = new TestClass();
            tc.TestedMethod("Production code");
        }        
    }
}
