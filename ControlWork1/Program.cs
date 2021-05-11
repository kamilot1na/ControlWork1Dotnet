using System;

namespace ControlWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird bird1 = new Bird();
            bird1.Id = 1;
            bird1.isNailed = false;
            bird1.Speed = 50;
            Bird bird2 = new Bird();
            bird2.Id = 2;
            bird2.isNailed = true;
            bird2.Speed = 60;
            Bird bird3 = new Bird();
            bird3.Id = 3;
            bird3.isNailed = false;
            bird3.Speed = 70;

            double birdSpeed = new Bird().getSpeed(1);
            Console.WriteLine(birdSpeed);
            Console.ReadLine();
        }
    }
}