using System;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Välj ett av följande alternativ:");
            Console.WriteLine("1. Subtrahera ett tal med ett annat");
            Console.WriteLine("2. Dividera ett tal med ett annat");
            Console.WriteLine("3. Avsluta programmet");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Ange det första talet: ");
                    double num1 = double.Parse(Console.ReadLine());
                    Console.Write("Ange det andra talet: ");
                    double num2 = double.Parse(Console.ReadLine());
                    double difference = num1 - num2;
                    Console.WriteLine($"Differensen är: {difference}");
                    break;

                case "2":
                    Console.Write("Ange det första talet: ");
                    double dividend = double.Parse(Console.ReadLine());
                    Console.Write("Ange det andra talet: ");
                    double divisor = double.Parse(Console.ReadLine());
                    if (divisor != 0)
                    {
                        double quotient = dividend / divisor;
                        Console.WriteLine($"Kvoten är: {quotient}");
                    }
                    else
                    {
                        Console.WriteLine("Det går inte att dividera med noll.");
                    }
                    break;

                case "3":
                    Console.WriteLine("Programmet avslutas.");
                    return;

                default:
                    Console.WriteLine("Ogiltigt val. Försök igen.");
                    break;
            }
        }
    }
}
