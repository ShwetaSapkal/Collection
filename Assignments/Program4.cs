// Course LINQ Queries
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace AdvancedTraining.Assignments
{
    class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
       
        public double Fees{ get; set; }
    }

    class CourseTest
    {
        static void Main(string[] args)
        {


            List<Course> crlist = new List<Course>()
       {
            new Course{Id=1,Name="Full stack development",Fees=40000},
            new Course{Id=2,Name="SAP",Fees=30000},
            new Course{Id=3,Name="Tally",Fees=20000},
            new Course{Id=4,Name="FCAT",Fees=10000},
            new Course{Id=5,Name="FCAT",Fees=15000},


       };

            var res1 = from c1 in crlist
                       where c1.Fees > 15000
                       select c1;

            foreach (var data in res1)
            {
                Console.WriteLine($"{data.Id}\t {data.Name}\t {data.Fees}");
            }
            Console.WriteLine("***********************************************************************");


            var res2 = from c2 in crlist
                       orderby c2.Name
                       select c2;

            foreach (var data in res2)
            {
                Console.WriteLine($"{data.Id}\t {data.Name}\t {data.Fees}");
            }
            Console.WriteLine("***********************************************************************");


            var res3 = from c3 in crlist
                       where c3.Name.Contains("FCAT")
                       select c3;

            foreach (var data in res3)
            {
                Console.WriteLine($"{data.Id}\t {data.Name}\t {data.Fees}");
            }
            Console.WriteLine("***********************************************************************");


            var res4 = from c4 in crlist
                       where c4.Name.StartsWith('F')|| c4.Name.StartsWith('T')
                       select c4;

            foreach (var data in res4)
            {
                Console.WriteLine($"{data.Id}\t {data.Name}\t {data.Fees}");
            }
            Console.WriteLine("***********************************************************************");

            var res5 = from c5 in crlist
                       orderby c5.Fees descending
                       select c5;

            foreach (var data in res5)
            {
                Console.WriteLine($"{data.Id}\t {data.Name}\t {data.Fees}");
            }
            Console.WriteLine("***********************************************************************");








        }
    }

}
