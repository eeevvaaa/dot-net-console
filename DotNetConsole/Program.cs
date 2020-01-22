using System;

namespace DotNetConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am going to the store today and I am getting " + args[0]);
            Console.WriteLine("Is there anything else you would like to get from the store?");
            string storeItem = Console.ReadLine();
            Console.WriteLine("We will also get " + storeItem + " from the store");
        }
    }
}
