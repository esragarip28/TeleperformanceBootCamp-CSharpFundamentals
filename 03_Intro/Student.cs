using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Intro
{
  /*
  * Class members
  * Fields
  * Methods
    *Constructor
    *Destructer-finalizer
  * Properties
  * Indexer
  * Nested Type
  * Event
  */
    class Student
    {
        //fields
        public string _name;
        public int _age;
        public DateTime _birthDate;
        public School _school;
        public void GoToSchool() 
        {
            Console.WriteLine($"{_school._name}");
        }
    }
    class School
    {
        public string _name;
    }

}
