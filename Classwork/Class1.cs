using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedTraining.Classwork
{
    public class Test<T> //place holder for type(int,float,doule,object,pro,emp stud...)
    {
        private T data;

        public void Add(T data)
        {
            this.data = data;
        }

        public T Get()
        {
            return data;
        }
    }
    class Class1
    {
        static void Main(string[] args)
        {
            Test<int> t1 = new Test<int>();
            t1.Add(10);
            Console.WriteLine(t1.Get());

            Test<string> t2 = new Test<string>();
            t2.Add("Hello");
            Console.WriteLine(t2.Get());

        }
    }
}
