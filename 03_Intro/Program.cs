using System;

namespace _03_Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //Usage of constructor
            Citizen citizen = new("esra","1********1");
            citizen._name = "new name";
            #endregion
            Product product = new Product("frezer");
            
        }
    }
}
