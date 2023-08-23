using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sample();
        }

        static void Sample()
        {
            Console.WriteLine("Welcome traveller. What is your name? ");
            string CharName = Console.ReadLine();
            Console.WriteLine($"Hello {CharName}, welcome to world of codecraft");
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("I see you want to see the Coding Rapper, Sir Code-a-l");
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine($"You may only see him with a gift of 100 peices of gold, how many peices do you have {CharName}?");
            int amountofGold = int.Parse(Console.ReadLine());
            Thread.Sleep(3000);
            Console.Clear();

            if (amountofGold >= 100)
            {
                Console.WriteLine($"Oh {amountofGold} peices of gold! you must be very successful in buissness {CharName}. Please fllow me to sir Code-a-lot.");
            }
            else
            {
                Console.WriteLine("go away pleb");
            }
            //ctrl+d copi code tee he
            //ctrl+k makes comet 


            Console.ReadLine();
        }

    }
}
