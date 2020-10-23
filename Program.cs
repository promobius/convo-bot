using System;
using System.Xml.Schema;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)

        {
           
            Console.WriteLine("what is your name?");

            string name = Console.ReadLine();

            Console.WriteLine($"Hi {name}");

            Console.WriteLine("How old are you?");

            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"So you are {num2}? Great!");

            Console.WriteLine("What are you?");

            string species = Console.ReadLine();

            Console.WriteLine($"Wierd, A {species} huh?");

            string response = Console.ReadLine();

            Console.WriteLine($"{response}?, Why are you proud of that?!");
            Console.WriteLine($"Just so i got it correct, you are a {num2} year old {species} called {name}? Did I get that right?");

            string last = Console.ReadLine();

            Console.WriteLine($"Okay since you said {last}, give me a number");
            int num1 = int.Parse(Console.ReadLine());

            int total = Sum(num2, num1);

            Console.WriteLine($"So in {num1} years you will be {total} years old!");

            string answer = Console.ReadLine();

            Console.WriteLine($"Since you said {answer}, I will now Terminate you!");

        }

        public static int Sum(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }
        
       
          public static int Multiply(int x, int y)

        {
            return x * y;
        }
           
    }

}
