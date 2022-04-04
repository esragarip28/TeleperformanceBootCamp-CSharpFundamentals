using System;

namespace _07._1_EncapsulationLib
{
    public class Protecter
    {
        public string GetStudentName(string password)
        {
            if (password.Equals("****"))
            {
                return new Student().Name;
            }
            else throw new Exception("unauthorizated to access student name.");
        }
    }
}
