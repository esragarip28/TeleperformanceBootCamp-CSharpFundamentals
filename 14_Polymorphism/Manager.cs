using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Polymorphism
{
    internal class Manager:Personal
    {
        //public override decimal Salary
        //{
        //    get => base.Salary;
        //    set => base.Salary=value;
        //}

        public override decimal Salary
        {
            get { return base.Salary; }

            set { base.Salary = value; } 
        }

        //we can override only get method.
        public override int NumberOfWorkDayPerMonth
        {
            get { return base.NumberOfWorkDayPerMonth; }
        }
    }
}
