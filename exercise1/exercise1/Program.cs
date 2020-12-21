using System;

namespace exercise1
{
    class Program
    {       
        static double playerspeed;
        static void Main(string[] args)
        {
            //exercise 1
            string charactername = "doha";
            double speed = 1.65;
            int age = 21;
            string superpower1 = "telepathy";
            string superpower2 = "mind reading";

            //Console.WriteLine("hello my name is {0}, and my superpowers are {1} and {2}. i am {3} years old and my speed is {4}. ", charactername, superpower1, superpower2, age, speed);

            //exercise 2
            string heroname = "mario";
            double heroheight = 1.14;
            int heroage = 45;
            string herosuperpower1 = "mind reading";
            string herosuperpower2 = "flying";

            int agedifference = heroage - age;
            Console.WriteLine("the age difference is {0}", agedifference);

            //bonus
            if (superpower1 == herosuperpower1 || superpower1 == herosuperpower2 || superpower2 == herosuperpower1 || superpower2 == herosuperpower2)
                Console.WriteLine("the hero and the villan share a superpower!!");
            else
                Console.WriteLine("the hero and the villan dont share any superpower");

            //ex 3
            Setspeed(2.5);
            Console.WriteLine("the current player speed is {0}", Getspeed());





            //ex 4
            int[] characterpowervalues = {3,7,9,2};
            comparepower(characterpowervalues[0], characterpowervalues[2]);

            int max = characterpowervalues[0];
            for (int i = 0; i < characterpowervalues.Length; i++)
            {
                if (characterpowervalues[i] > max)
                    max = characterpowervalues[i];
            }
            Console.WriteLine("the most powerful power is {0}", max);

        }

        static string comparepower(int x, int y)
        {
            if (x > y)
                return "the first power is more powerful than the second";
            else if (x < y)
                return "the second power is more powerful than the first";
            else return "both powers have the exact same power!";
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
