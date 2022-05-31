using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdvancedTraining.Classwork
{
    /* class Product1
     {
         public int Id { get; set; }
         public string Name { get; set; }

         public int Price { get; set; }
     }

     class Program
     {
         static void Main(string[] args)
         {


             List<Product1> productlist = new List<Product1>()
         {
         new Product1{ Id=1,Name="Hp laptop", Price=35000},
         new Product1{ Id=2,Name="Sony laptop", Price=45000},
         new Product1{ Id=3,Name="Lenovo laptop", Price=30000},
         new Product1{ Id=4 ,Name="Dell laptop", Price=50000},
         new Product1{ Id=5,Name="Accer laptop", Price=50000},
          new Product1{ Id=6,Name="Dell laptop", Price=55000},
         };

             var result = from p in productlist
                          where p.Name.StartsWith('H')
                          orderby p.Price

                          select p;

             var result = from p in productlist
                          where p.Name.Contains("Dell")
                          orderby p.Price descending

                          select p;

             foreach (Product1 p in result)
             {
                 Console.WriteLine($"{p.Name}  {p.Price}");
             }
         }

     }
 */


    class Employee1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public double Salary { get; set; }
        public string Dept { get; set; }

    }


    class EmpTest1
    {
        static void Main(string[] args)
        {
            List<Employee1> emplist = new List<Employee1>()
            {
                 new Employee1{Id=1,Name="shweta",City="Pune",Salary=30000,Dept="developer"},
                 new Employee1{Id=2,Name="supriya",City="Thane",Salary=40000,Dept="hr"},
                 new Employee1{Id=3,Name="sharayu",City="Pune",Salary=100000,Dept="ceo"},
                 new Employee1{Id=4,Name="shubh",City="Nashik",Salary=50000,Dept="manager"},



            };

            var res1 = from e in emplist
                      where e.Salary > 45000
                      select e;

            foreach (var data in res1)
            {
                Console.WriteLine($"{data.Id}\t{data.Name}\t{data.City}\t{data.Salary}\t{data.Dept}");
            }
            Console.WriteLine("*********************");

            var res2 = from e in emplist
                       orderby e.Name
                       select e;

            foreach (var data in res2)
            {
                Console.WriteLine($"{data.Id}\t{data.Name}\t{data.City}\t{data.Salary}\t{data.Dept}");
            }
            Console.WriteLine("*********************");

            var res3 = from e in emplist
                       where e.City.Contains("Mumbai")
                       select e;

            foreach (var data in res3)
            {
                Console.WriteLine($"{data.Id}\t{data.Name}\t{data.City}\t{data.Salary}\t{data.Dept}");
            }
            Console.WriteLine("*********************");


            var res4= from e in emplist
                      where e.Dept=="Hr"
                      select e;
            foreach (var data in res4)
            {
                Console.WriteLine($"{data.Id}\t{data.Name}\t{data.City}\t{data.Salary}\t{data.Dept}");
            }
            Console.WriteLine("*********************");


             var res5 = from e in emplist
                        orderby e.Salary descending
                        select e;

             foreach (var data in res5)
             {
                 Console.WriteLine($"{data.Id}\t{data.Name}\t{data.City}\t{data.Salary}\t{data.Dept}");
             }
             Console.WriteLine("*********************");

             

            var res6 = from e in emplist
                       where e.Name.StartsWith('a')||e.Name.StartsWith('A')||e.Name.StartsWith('K')||e.Name.StartsWith('k')
                       select e;
            foreach (var data in res6)
            {
                Console.WriteLine($"{data.Id}\t{data.Name}\t{data.City}\t{data.Salary}\t{data.Dept}");
            }
            Console.WriteLine("*********************");

            var res7 = from e in emplist
                       where e.Salary<40000 && e.City.Contains("Pune")
                       select e;
            foreach (var data in res7)
            {
                Console.WriteLine($"{data.Id}\t{data.Name}\t{data.City}\t{data.Salary}\t{data.Dept}");
            }
            Console.WriteLine("*********************");


        }
    }
}