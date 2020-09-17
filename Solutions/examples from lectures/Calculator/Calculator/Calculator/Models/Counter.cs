using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calculator.Models
{
    public static class CounterLogic
    {
        public static int Counter { get; private set; }
        public static void Increase() => Counter++;
    }
}