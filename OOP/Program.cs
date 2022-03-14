using System;

namespace _01_Intro
{
     internal class Program
    {
        static void Main(string[] args)
        {
            CupBoard board = new CupBoard();
            //CupBoard board1 = new();
            board.color = "white";
            board.numberOfShelf = 4;
            board.OpenCabinetDoor();

        }
       
    }
     class CupBoard
    {
        public int numberOrCabinetDoor;
        public string color;
        public int numberOfShelf;
        public double height;
        public double widht;
        public double depth;

        public void OpenCabinetDoor()
        {

        }
    }
}
