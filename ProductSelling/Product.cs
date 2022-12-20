using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSelling
{
    internal class Product
    {
        private string _name;

        public string? Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length == 0)
                {
                    Console.WriteLine("Product name isnt correct");
                }
                else
                {
                    _name = value;
                }


            }
        }

        private int _price;
        public int Price
        {
            get { return _price; }



            set
            {
                if (value > 1)
                {
                    _price = value;
                }
                else
                {
                    Console.WriteLine("Price cant be less than 1.");
                }


            }



        }
        private int _count;
        public int Count
        {
            get { return _price; }


            set
            {
                if (value > 0)
                {
                    _count = value;
                }
                else
                {
                    Console.WriteLine("Count cant be less than 0.");
                }
            }
        }
        int TotalIncome = 0;

        public Product(string name, int price, int count)
        {
            if (string.IsNullOrWhiteSpace(name) || name.Length == 0)
            {
                Console.WriteLine("Cant assing name try again.");
            }
            else
            {
                this.Name = name;
                this.Price = price;
                this.Count = count;
            }


        }
















        public void Sell()
        {
            if (_count > 0)
            {
                _count -= 1;
                TotalIncome += _price;
            }
            else
            {
                Console.WriteLine("There is no product left.");
            }


        }
    }
}