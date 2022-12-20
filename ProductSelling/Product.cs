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

        public string? Name
        {
            get => Name;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length == 0)
                {
                    Console.WriteLine("Product name isnt correct");
                }
                else
                {
                    Name = value;
                }


            }
        }
        public int Price
        {
            get { return Price; }



            set
            {
                if (value > 1)
                {
                    Price = value;
                }
                else
                {
                    Console.WriteLine("Price cant be less than 1.");
                }


            }



        }
        public int Count
        {
            get { return Price; }


            set
            {
                if (value > 0)
                {
                    Count = value;
                }
                else
                {
                    Console.WriteLine("Count cant be less than 0.");
                }
            }
        }
        int TotalIncome=0;
  
        public Product(string name,int price,int count)
        {
            if (string.IsNullOrWhiteSpace(Name)||Name.Length==0)
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
            if (Count > 0)
            {
                Count -= 1;
                TotalIncome += Price;
            }
            else
            {
                Console.WriteLine("There is no product left.");
            }


        }
    }
}
