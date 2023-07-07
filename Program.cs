// See https://aka.ms/new-console-template for more information
using System;
using System.Net.Security;

namespace Nifemi;

     class Program
{
              static void Main(string[] args)
    {
        //int cap = 100;
        //int on, wait;



        Console.WriteLine("WELCOME TO BOBS CITY BUS!");
        Console.WriteLine("how many people can be on the bus at once?");
        int cap =Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("how many people are on the bus at the moment?");
        int on = Convert.ToInt32(Console.ReadLine());
        if (cap > on)
        {
            int sub1 = cap - on;

            Console.WriteLine("There is space for"  + sub1 +  "people on the bus");
        }

        Console.WriteLine("How many people are waiting for the bus ride?");
        int wait =Convert.ToInt32 (Console.ReadLine());
        
        if (cap > wait && wait < on)
        {
            int sub2 = cap - wait;

            Console.WriteLine("There is space for"  + sub2 + "people on the bus");
        }
    }
}

