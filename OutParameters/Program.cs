using System;

namespace OutParameters
{
    class Program
    {
        public static void GetMultipleRandomValue(out int x, out double y)
        {
            var random = new Random();
            x = random.Next();
            y = random.NextDouble(); //Gets random value of double
        }

        static void Main(string[] args)
        {
            //int random1, random2; //Taking both int
            //GetMultipleRandomValue(out random1, out random2);
            //Can Call both ways
            GetMultipleRandomValue(out int random1, out double random2);

            Console.WriteLine($"{random1}, {random2}"); //returns 1409752713, 0.126955046843251
        }
    }
}

