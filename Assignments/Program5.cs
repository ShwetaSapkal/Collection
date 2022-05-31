// Student LINQ Queries
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AdvancedTraining.Assignments
{
    class Student
    {
        public int Rollno { get; set; }
        public string Name { get; set; }
        public float Percentage { get; set; }
        public string Branch { get; set; }

    }

    class StudentTest
    {
        static void Main(string[] args)
        {
            List<Student> stud = new List<Student>()
            {
                new Student{ Rollno=1,Name="Shweta",Percentage=82.60F,Branch="Computer sci"},
                new Student{ Rollno=2,Name="Supriya",Percentage=80,Branch="Biotechnology"},
                new Student{ Rollno=3,Name="Sharayu",Percentage=70.00F,Branch="Arts"},
                new Student{ Rollno=4,Name="Shubh",Percentage=90,Branch="Bsc Agree"},
                new Student{ Rollno=5,Name="Mona",Percentage=77.99F,Branch="Computer sci"},
                new Student{ Rollno=6,Name="Malhar",Percentage=91.22F,Branch="Engineer"},
                new Student{ Rollno=7,Name="Shivani",Percentage=97.60F,Branch="Biotechnology"},
                new Student{ Rollno=8,Name="Shailesh",Percentage=78.91F,Branch="Hotel Mangagement"},

            };

            var res1 = from s1 in stud
                       orderby s1.Name descending 
                       select s1;

            foreach (var data in res1)
            {
                Console.WriteLine($"{data.Rollno}\t {data.Name}\t {data.Percentage}\t {data.Branch}");
            }

            Console.WriteLine("**********************************************************************************");

            var res2 = from s2 in stud
                       where s2.Branch.Contains("Computer sci")
                        select s2;

            foreach (var data in res2)
            {
                Console.WriteLine($"{data.Rollno}\t {data.Name}\t {data.Percentage}\t {data.Branch}");
            }

            Console.WriteLine("**********************************************************************************");


            var res3 = from s3 in stud
                       where s3.Rollno==5
                       select s3;

            foreach (var data in res3)
            {
                Console.WriteLine($"{data.Rollno}\t {data.Name}\t {data.Percentage}\t {data.Branch}");
            }

            Console.WriteLine("**********************************************************************************");



            var res4 = from s4 in stud
                       where s4.Name.StartsWith('M')
                       select s4;

            foreach (var data in res4)
            {
                Console.WriteLine($"{data.Rollno}\t {data.Name}\t {data.Percentage}\t {data.Branch}");
            }


            var res5 = from s5 in stud
                       where s5.Percentage>85
                       select s5;

            foreach (var data in res5)
            {
                Console.WriteLine($"{data.Rollno}\t {data.Name}\t {data.Percentage}\t {data.Branch}");
            }

            Console.WriteLine("**********************************************************************************");



           



        }
    }
}
