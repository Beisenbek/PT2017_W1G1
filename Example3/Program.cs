using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    class Student
    {
        public int age;
        public string name;
        public void GetInfo()
        {
            Console.WriteLine(age + " " + name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.age = 20;
            s.name = "Sapar";
            s.GetInfo();
        }
    }
}
