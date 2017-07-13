using System;
using BuilderDemo.Builders.Person;
using BuilderDemo.Models;

namespace BuilderDemo
{
    class Program
    {

        static void ConfigureUser()
        {
            //Implmenting dynamic type checking. Gives the compile time error if the state of object is invalid
            Person person =
                PersonBuilder
                    .Person()
                    .WithFirstName("Sanjay")
                    .WithLastName("bHASKAR")
                    .Build();

            Console.WriteLine(person);
            Console.WriteLine();

        }

        static void Main(string[] args)
        {

            ConfigureUser();

            Console.WriteLine("end...");
            Console.ReadLine();
        }
    }
}
