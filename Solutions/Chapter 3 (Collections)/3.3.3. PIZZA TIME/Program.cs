﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3._3.PIZZA_TIME
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza p = new Pizza();
            User u = new User();
            
            p.pizzaReady+= u.GoToReadyPizza;
            p.makePiza();
            p.pizzaReady-= u.GoToReadyPizza;
        }
    }
}
