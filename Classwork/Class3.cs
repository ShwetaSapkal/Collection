using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedTraining.Classwork
{
    public class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
    public class Department
    {
        public string DName { get; set; }
        public int Id { get; set; }
        public List<Employee> Emp = new List<Employee>();

    }
    class Class3
    {
        static void Main(string[] args)
        {
            List<Department> dept = new List<Department>() {
              new Department{ DName="Science",Id=1, Emp={
                      new Employee{ Name="Shweta",Id=101},
                      new Employee{ Name="Supriya",Id=102},
                      new Employee{ Name="Sharayu",Id=103},


                }
             },

              new Department{ DName="Commerce",Id=2, Emp={
                      new Employee{ Name="Shubh",Id=201},
                      new Employee{ Name="Shiv",Id=202},
                      new Employee{ Name="Sneha",Id=203},

                 } }

              };



            foreach (Department d in dept)
            {
                Console.WriteLine(d.DName);
                foreach (Employee e in d.Emp)
                {
                    Console.WriteLine($"\t {e.Name} {e.Id}");
                }
            }







        }
    }
}
