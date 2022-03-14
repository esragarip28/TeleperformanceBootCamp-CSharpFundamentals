using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Intro
{
    class Product
    {

        //usage  of "this" keyword
        string productName;
        decimal price;
        int stock;
        public Product(string productName)
        {
            this.productName = productName;
        }
        public Product(string productName, decimal price, int stock) : this(productName) 
        { 
            this.price = price;
            this.stock = stock;
        }
        public void Add()
        {
            this.stock = 10;
        }


    }
}
