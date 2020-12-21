using System;

namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string charactername = "doha";
            double speed = 1.65;
            int age = 21;
            string superpower1 = "telepathy";
            string superpower2 = "mind reading";

            Console.WriteLine("hello my name is {0}, and my superpowers are {1} and {2}. i am {3} years old and my speed is {4}. ", charactername, superpower1, superpower2, age, speed);


            string heroname = "mario";
            double heroheight = 1.14;
            int heroage = 45;
            string herosuperpower1 = "super jump";
            string herosuperpower2 = "flying";

            int agedifference = heroage - age;
            Console.WriteLine("the age difference is {0}", agedifference);
        }
    }
}
