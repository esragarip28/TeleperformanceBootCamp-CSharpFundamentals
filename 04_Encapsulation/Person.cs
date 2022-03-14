using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Encapsulation
{
     
    class Person
    {
        private string name;
        private DateTime birtDate;
        //Getter method
        public string GetName()
        {
            return name;
        }

        //Setter method, we can add some conditions if it is necessary.
        public void SetName(string name)
        {
            if (name.Length > 3)
            {
                this.name = name;
            }
            else throw new Exception("length of name must be at least 3 characters");
            
        }
        public void SetBirthYear(DateTime birthDate)
        {
            if (DateTime.Now.Year - birthDate.Year < 18)
            {
                throw new Exception("The age must be greater than 18.");
            }
            else this.birtDate = birthDate; ;

        }

        //year, month, day
        public DateTime GetBirthDate()
        {
            return this.birtDate;
        }

    }
}
