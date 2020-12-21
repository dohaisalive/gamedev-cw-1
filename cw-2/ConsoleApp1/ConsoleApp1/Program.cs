using System;

namespace ConsoleApp1
{	
	
	
    class Program
    {
		static double playerspeed;
        static void Main(string[] args)
        {
        Setspeed(2.5);
		Console.WriteLine("the current player speed is {0}", Getspeed());
        }

		static void Setspeed(double speed)
		{
			playerspeed = speed;
		}

		static double Getspeed()
		{
			return playerspeed;
		}
	}
}
