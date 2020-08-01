using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _3._3._3.PIZZA_TIME
{
     class Pizza
    {
        public delegate void delegatePizza();

        
        public event delegatePizza pizzaReady;
        public void makePiza()
        {
            for (int i = 0; i < 100000000; i++)
            {
                if (i == 10000000)
                {
                    pizzaReady();

                }
            }
            
        }
    }
}
