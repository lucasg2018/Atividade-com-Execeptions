using System;
using Exercicio_Exceptions.Entities;
using Exercicio_Exceptions.Entities.Exceptions;

namespace Exercicio_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double balance = double.Parse(Console.ReadLine());
            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine());

            Account account = new Account(number, holder, balance, withdrawLimit);

            Console.Write("\nEnter amount for withdraw: ");
            double saque = double.Parse(Console.ReadLine());
            
            try
            {
                account.WithDraw(saque);
                Console.WriteLine("New balance: " + account.Balance);
            }
            catch (DomainExceptions e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Withdraw error: " + e.Message);
                Console.ResetColor();
            }
        }
    }
}
