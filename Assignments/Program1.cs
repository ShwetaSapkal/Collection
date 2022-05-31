using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace AdvancedTraining.Assignments
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
    }


    class EmployeeTest1
    {
        static void Main(string[] args)
        {
            Stack<Employee> emp = new Stack<Employee>
            {
               // new Employee{ Id=101,Name="Shweta", Salary=20000},
            };
            
            
            /*Stack<int> st1 = new Stack<int>();
            st1.Push(1);
            st1.Push(2);

            Stack<string> st2 = new Stack<string>();
            st2.Push("Shweta");
            st2.Push("Supriya");

            Stack<double> st3 = new Stack<double>();
            st3.Push(20000);
            st3.Push(30000);

            foreach (int id in st1 )
            {
                Console.WriteLine(id);
               

            }

            foreach (string name in st2)
            {
                Console.WriteLine(name);
            }

            foreach (double salary in st3)
            {
                Console.WriteLine(salary);
            }
*/
           // Console.WriteLine($"{st1.id}  {e.Name}  {e.Salary}");


        }
    }
}
