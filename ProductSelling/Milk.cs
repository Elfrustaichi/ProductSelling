using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSelling
{
    internal class Milk : Product
    {
        public readonly int volume = 5;
        public readonly string Fatrate = "1,8%";

        public Milk(string name, int price, int count) : base(name, price, count)
        {



        }
    }
}