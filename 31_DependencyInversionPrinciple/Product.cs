using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_DependencyInversionPrinciple
{
    class Product
    {
        public string ProductName { get; set; }
        public  decimal Price { get; set; }
    }

    class ProductManager
    {
        // DbLogger dbLogger;
        //All changes in the DbLogger class will affect the ProductManager class
        ILogger logger;

        //constructor dependecy injection method.
        public ProductManager(ILogger logger)
        {
            this.logger = logger;     
        }

        //another method for dependency injection
        public void InjectLog(ILogger logger)
        {
            this.logger = logger;
        }

        //also we can use property injection method.


        //public ProductManager()
        //{
        //    logger = new DbLogger();
        //    //dbLogger = new DbLogger();
        //}
        public void Add(Product product)
        {
            logger.Log("product has been added");
            //dbLogger.Log("Product has been added...");
        }

        public void Delete(Product product)
        {
            logger.Log("product has been deleted");
            //dbLogger.Log("Product has been deleted...");
        }
    }
}
