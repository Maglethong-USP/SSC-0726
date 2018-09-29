using System;
using System.Runtime.Remoting.Services;

namespace SSC0726.ConsoleClient
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter number of dice to cast: ");
            int amount = 1, sides = 6;
            int.TryParse(Console.ReadLine(), out amount);

            Console.Write("Enter number of sides of dice: ");
            int.TryParse(Console.ReadLine(), out sides);

            var dto = new Swagger.Client.CSharp4.Api
                .DiceApi()
                .ApiDiceGet(amount, sides);
           
            Console.Write($"Result: {dto.Sum} ({string.Join(" + ", dto.Values)})");
        }
    }
}