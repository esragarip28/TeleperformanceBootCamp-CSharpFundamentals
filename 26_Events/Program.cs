using System;

namespace _26_Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Esra";
            Instructor instructor = new Instructor();
            student.HandUp += instructor.GiveRightToSpeak;

            instructor.Teach();
            instructor.Teach();
            student.AskQuestion();
            Console.Read();
        }
    }
}
