using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _3._3._3.PIZZA_TIME
{
   public  class Pizza
    {
        delegate void delegatePizza(string message);
        event delegatePizza pizzaReady;
        public Pizza()
        {
            for (int i = 0; i < 100000000; i++)
            {
                if (i == 10000000)
                {
                    pizzaReady("Пицца готова!");

                }
            }
            
        }
    }
}
