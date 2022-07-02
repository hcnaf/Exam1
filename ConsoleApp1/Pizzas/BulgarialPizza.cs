using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Pizzas
{
    internal class BulgarialPizza : Pizza
    {
        public BulgarialPizza()
               : base("Bulgarial pizza") { }

        public override int GetCost()
        {
            return 8;
        }

    }
}
