using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*namespace ConsoleApplication2
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.ReadLine();
        }
    }
}
/*
/namespace ConsoleApplication2
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            string firstName = "John";
            string lastName = "Doe";

            Console.WriteLine("Name: " + firstName + " " + lastName);

            Console.WriteLine("Please enter a first name:");
            firstName = Console.ReadLine();

            Console.WriteLine("Newname:" + firstName + " " + lastName);
            Console.ReadLine();
        }
    }
}
*/
namespace ConsoleApplicaton2
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            int number1, number2;

            Console.WriteLine("Please enter a  number:");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Than you please enter one more number:");
            number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Adding the two numbers: " + (number1 + number2));

            Console.ReadLine();

        }

    }
}