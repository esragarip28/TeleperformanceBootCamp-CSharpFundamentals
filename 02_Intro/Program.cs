using System;

namespace _02_Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //following usage is not useful so we must use object.
            //Also, If we use the following code blog, we have to pay attention index to match students and their grades.
            //    string[] students =
            //    {
            //        "Student1","Student2","Student3"
            //    };
            //    int[] grades = {90,80,95};
            //    for(int i = 0; i < students.Length; i++)
            //    {
            //        Console.WriteLine(students[i] + " :" + grades[i]);
            //    }

            Student student = new Student();
            student.visa1 = 100;
            student.visa2 = 90;
            student.name = "Esra";
            Student student2 = new();
            student2.visa1 = 85;
            student2.name = "Esra";
        }
    }

    class Student
    {
        public int visa1;
        public int visa2;
        public string name;
    }
}
