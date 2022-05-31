/*using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedTraining.Assignments
{
    public delegate void Mydel();

    class Bank
    {
        public event Mydel Zerobalevent;

        public event Mydel Lessbalevent;
        public void Withdraw(int debit)
        {
          // private int balance=5000;
            int balance=5000 ;
            if (debit > balance)
                Lessbalevent();
            else if (debit == balance)
                Zerobalevent();

            int result = balance - debit;

            if (result >= 0)
            {
                Console.WriteLine($"Avialable balance is{result}");
            }
            else 
            {
                Console.WriteLine($" please enter suffiecient amount your acc balance is {balance}");
            }
            Console.WriteLine();
        }
    }


    class Program2
    {
        static void ErrorMsg()
        {
            Console.WriteLine("Insufficient balance");
        }

        static void ErrorMsg1()
        {
            Console.WriteLine("Zero balance");
        }
        static void Main(string[] args)
        {
            Bank b1 = new Bank();
            b1.Zerobalevent += new Mydel(ErrorMsg1);
            b1.Lessbalevent += new Mydel(ErrorMsg);
            b1.Withdraw(5000);
        }
    }
}
*/


using System;
using System.Collections.Generic;
using System.Text;
namespace AdvancedTraining.Assignments
{
    public delegate void Mydel();
    class Bank
    {
        private double balance;
        public event Mydel CreditAcc;
        public event Mydel LowBal;
        public event Mydel ZeroBal;

        public Bank()
        {
            balance = 5000;
        }

        public void CreditAmount(double amt)
        {
            balance = balance + amt;
            CreditAcc();
        }

        public void Debit(double debit)
        {
            if (balance == 0)
            {
                ZeroBal();
            }
            else if (balance < debit)
            {
                LowBal();
            }
            else 
            {
                balance = balance - debit;
            }
            Console.WriteLine($"Current balance {balance}");
        }
        

    }


    class EventMsg
    {
        public void CreditMsg()
        {
            Console.WriteLine("Yor account has been credited");
        }

        public void LowBalMsg()
        {
            Console.WriteLine("Your account have no balance debit the amount");
        }

        public void ZeroBalMsg()
        {
            Console.WriteLine("Your account has zero balance");
        }


    }

    class Program2
    {
        static void Main(string[] args)
        {


            Bank bk = new Bank();
            EventMsg mg = new EventMsg();

            bk.CreditAcc += new Mydel(mg.CreditMsg);
            bk.LowBal += new Mydel(mg.LowBalMsg);
            bk.ZeroBal += new Mydel(mg.ZeroBalMsg);
            bk.CreditAmount(1000);
            bk.Debit(7000);


        }
    }



}