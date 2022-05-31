using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedTraining.Classwork
{
    public class Student
    {
        public string Name { get; set; }
        public string City { get; set; }
    }
    public class Course
    {
        public string CName { get; set; }

        public int Fees { get; set; }

        public List<Student> Students = new List<Student>();

    }


    class Class2
    {
        static void Main(string[] args)
        {
            List<Course> courses = new List<Course>() {
              new Course{ CName="C#",Fees=5000, Students={
                new Student{ Name="Shweta",City="Pune"} ,
                 new Student{ Name="Supriys",City="Thane"} ,
                  new Student{ Name="Neha",City="Nashik"} ,
                }
             },

              new Course{ CName="MVC",Fees=4000,Students={ 
                  new Student{ Name="Pooja",City="Pune"},
                  new Student{ Name="sneha",City="delhi"},
                  new Student{ Name="megha",City="Pune"},

                  } }

              };

        }
    }
}
