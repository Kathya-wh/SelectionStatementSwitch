using System;

namespace SelectionStatementSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject?");
            var subject = Console.ReadLine();

            switch (subject)
            {
                case "Math":
                    Console.WriteLine("Math is challenging but doable subject!");
                    break;
                case "Science":
                    Console.WriteLine("Science is an awesome subject");
                    break;
                case "Spanish":
                    Console.WriteLine("Spanish is a great language!");
                    break;
                case "History":
                    Console.WriteLine("History is my personal favorite!");
                    break;
                case "Biology":
                    Console.WriteLine("Biology is very interesting!");
                    break;
                default:
                    Console.WriteLine($"Learning is great! I like {subject} as well");
                    break;

            }
        }
    }
}
