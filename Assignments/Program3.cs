using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedTraining.Assignments
{

    public class Customer
    {
       public int Cid { get; set; }
        public string Cname { get; set; }
        public string Caddress { get; set; }
        public List<Accounts> aclist = new List<Accounts>();
    }

    public class Accounts
    {
        public string Actype { get; set; }
        public long AcNo { get; set; }
        public List<Loan> lnlist = new List<Loan>();
    }

    public class Loan
    {
        public string LType{get; set;}
    }



    class Program3
    {
        static void Main(string[] args)
        {
            List<Customer> clist = new List<Customer>()
            {
                new Customer{ Cid=1,Cname="Shweta",Caddress="PUne" ,
                aclist={ new Accounts { AcNo=11,Actype="current",lnlist = { new Loan { LType="Car Loan"} } } }
                }
            };

            foreach (Customer c in clist)
            {
                Console.WriteLine($"Id={c.Cid},Name={c.Cname},Location={c.Caddress}");
                foreach (Accounts a in c.aclist)
                {
                    Console.WriteLine($"AcNo={a.AcNo},Actype={a.Actype}");
                    foreach (Loan l in a.lnlist)
                    {
                        Console.WriteLine($"Loan={l.LType}");
                    }
                }
            }
        }
    }
}
