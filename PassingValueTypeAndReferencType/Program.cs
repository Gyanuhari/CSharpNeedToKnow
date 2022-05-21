using System;

namespace PassingValueTypeAndReferencType
{
    class Program
    {
        static void Main(string[] args)
        {
            int myRefNum = 10, myValNum = 10;
            Console.WriteLine($"MyRefNum and myValNum before passing: {myRefNum} & {myValNum}");

            ProcessNumbers(ref myRefNum, myValNum);

            Console.WriteLine($"MyRefNum and myValNum after passing: {myRefNum} & {myValNum}");
        }

        private static void ProcessNumbers(ref int refNum, int valNum)
        {
            refNum += valNum;
        }
    }
}

