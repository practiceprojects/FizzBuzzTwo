using System;

namespace FizzBuzz2.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzzer = new FizzBuzzer();

            for (int i = 0; i < 100; i++)
            {
                var output = fizzBuzzer.FizzBuzz(i);
                Console.WriteLine(output);
            }
            Console.ReadLine();
        }
    }
}