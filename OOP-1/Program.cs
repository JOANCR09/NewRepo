using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Evans", 1000);
            Console.WriteLine($"Nombre {account.Owner}, numero de cueta: {account.Number} y su credito es de: {account.Balance}");      
            
            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);
            
            account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            Console.WriteLine("su saldo es: "+account.Balance);

            Console.WriteLine($"Nombre {account.Owner}, numero de cueta: {account.Number} y su credito es de: {account.Balance}");
            Console.ReadLine();

            // Test that the initial balances must be positive.
            //BankAccount invalidAccount;
            //try
            //{
            //    account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
            //}
            //catch (InvalidOperationException e)
            //{
            //    Console.WriteLine("Exception caught trying to overdraw");
            //    Console.WriteLine(e.ToString());
            //}

            Console.WriteLine(account.GetAccountHistory());

            Console.ReadLine();
        }
    }
}
