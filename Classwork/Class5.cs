using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedTraining.Classwork
{

    public delegate int MyDelegate1(int n1, int n2);

    public class Calculation1
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }




    class Class5
    {
        static void Main(string[] args)
        {


            Calculation1 cal = new Calculation1();
            // += add method ref in the invocation list
            MyDelegate1 mydel1 = new MyDelegate1(cal.Add); // added method reference
            mydel1 += new MyDelegate1(cal.Sub);
            mydel1 += new MyDelegate1(cal.Multiply);

            // -=
            mydel1 -= new MyDelegate1(cal.Sub);

            Delegate[] list = mydel1.GetInvocationList();
            foreach (Delegate d in list)
            {
                Console.WriteLine(d.Method);
                Console.WriteLine(d.DynamicInvoke(45,32));
            }

        }

    }
}
