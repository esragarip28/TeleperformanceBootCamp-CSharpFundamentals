using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_AccessModifiers
{
    class Person
    {

        // string name; default private
        //default access modifier for class is internal

        private string name;
        private void PrivateMethod()
        {

        }
        protected void ProtectedMethod()
        {

        }
        public void PublicMethod() { }
        internal void InternalMethod() { }

    }
}
