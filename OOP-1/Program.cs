using System;
using System.Collections.Generic;
using System.Linq;
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
            Console.ReadLine();
        }
    }
}
