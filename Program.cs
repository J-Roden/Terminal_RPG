using System;

namespace Terminal_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("\n\n\n\n----Welcome brave adventurer!----\n\n" +
                                     "What might I call you?\n");
            string user = Console.ReadLine();
            System.Console.WriteLine($"Well met {user}! \n " + 
                                      "Before you lays a grand adventure rich with danger and reward!\n" +
                                      "But before you set off we have a few things to go over first. \n\n" +
                                      "To start how many will accompany you on this quest?");
            string partySize = Console.ReadLine();
        }
    }
}
