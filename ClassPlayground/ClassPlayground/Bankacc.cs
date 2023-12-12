using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlayground
{
    public class Bankacc
    {
        public int accountNumber;
        public string holderName;
        public string currency;
        public double balance;
        public Bankacc(int accountNumber, string holderName, string currency, double balance)
        {
            this.accountNumber = accountNumber;
            this.holderName = holderName;
            this.currency = currency;
            this.balance = balance;
        }
        public void Deposit(int a)
        {
            while (int.TryParse(Console.ReadLine(), out a))
            {
                if (a != null)
                {
                    balance += a;
                    Console.WriteLine($"Uspesny vklad {a}Kc");
                }
                else
                {

                }
            }
        }
        public void Withdraw()
        {

        }
    }
}
