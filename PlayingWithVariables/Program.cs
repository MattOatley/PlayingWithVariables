using System;

namespace PlayingWithVariables
{
    class Program
    {
        static void Main(string[] args)
        {

            string name;

            string address;

            name = "Matt";

            address = "11933 Parkbrook";

            int myAge = 30;

            char charabbrev = 'M';
            
            bool isAlive = true;

            double healthPoints = 50.5;

            decimal playerDmg = 25.55m;


           



            Console.WriteLine("Hello World!");
            Console.WriteLine($"My name is {name}, I live at {address}, and my age is {myAge}. ");
            Console.WriteLine($"In the game I am working on the player will have {healthPoints} health points, and will deal {playerDmg} points of damage");
            Console.WriteLine($"When you start the game as {name}, also known as {charabbrev}, you are alive, this is {isAlive}");
        }
    }
}
