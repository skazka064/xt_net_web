using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3._3.PIZZA_TIME
{
   public  class Pizza
    {
        delegate void Handler(string message);
        event Handler Notify;
        public Pizza()
        {
            
            Notify?.Invoke("Ваша пицца готова!");
        }
    }
}
