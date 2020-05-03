using System;

namespace UnitTestPOC
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount("Mark", 11.99);

            ba.Credit(5.77);
            ba.Debit(11.22);
            Console.WriteLine("Current balance is ${0}", ba.Balance);
            Console.ReadLine();
        }
    }
    
}
