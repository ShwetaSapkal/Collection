using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedTraining.Classwork
{
    public delegate void Mydel1(string s);
    class UprLower
    {
      public void UprCase(string s)
        {
            //s = s.ToUpper();
            Console.WriteLine(s.ToUpper());
        }

        public void LwrCase(string s)
        {
           // s = s.ToLower();
            Console.WriteLine(s.ToLower());
        }
    }


    class Class6
    {
        static void Main(string[] args)
        {
            UprLower ul = new UprLower();
            Mydel1 m1 = new Mydel1(ul.UprCase);
            m1 += new Mydel1(ul.LwrCase);
            Delegate[] list = m1.GetInvocationList();

            foreach (Delegate d in list)
            {
                Console.WriteLine(d.Method);
                Console.WriteLine(d.DynamicInvoke("ShwEta"));
            }
        }
    }
}
