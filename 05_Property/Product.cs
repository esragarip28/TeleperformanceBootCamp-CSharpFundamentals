using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Property
{
    class Product
    {
        /*
         * With compiler process, property create field automatically
         */
        public string Name { get; set; }//auto property
        //prop+tab+tab: shortcut to create property.
        public DateTime ExpireDate { get; set; }

        //we can use Property after defining fields;
        private int stock;
        //public int Stock { get; set; }
        public int Stock
        {
            //value: input that user will give.
            get {  return stock; }
            set {
                if (value < 0)
                {
                    throw new Exception("Stock cannot be negative");
                }
                stock = value; }
        }

        // we can make only get or set method due to condition.
        //the following property is readonly property.
        public int Days
        {
            get { return this.ExpireDate.Year-DateTime.Now.Year; }
        }

        public decimal Tax
        {
            set { this.ExpireDate = DateTime.Now; }
        }

        /*In auto property we cannot make only  set because this time, property cannot define variable and assign value it.
         *To create field by property, get method is necessary
         */
        public decimal Price { get; set; }
        public string Category { get; private set; }
    }
}
