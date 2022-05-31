// delegates
// single delegates
using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedTraining.Classwork
{
    // step1: declare the delegate
    public delegate int MyDelegate(int n1, int n2);

    public delegate double MyDel2(double d1, double d2);
    public class Calculation
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Multiply(double d1, double d2)
        {
            return d1 * d2;
        }
    }
    class Class4
    {
        static void Main(string[] args)
        {
            Calculation c = new Calculation();
            MyDelegate mydel = new MyDelegate(c.Add);// added method reference
            int res=mydel.Invoke(20,30);
            Console.WriteLine(res);

            MyDel2 obj = new MyDel2(c.Multiply);
            double res1 = obj.Invoke(20, 30);
            Console.WriteLine(res1);
        }
    }
}
