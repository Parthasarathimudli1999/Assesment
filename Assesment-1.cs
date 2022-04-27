using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assesment1
{
    class Person
    {
        string Name;
        public Person(string name)
        {
            this.Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
    class Student : Person
    {
        string name;
        public Student(string name) : base(name)
        {
            this.name = name;
        }
        public void Study()
        {
            Console.WriteLine("Student is Studying");
        }

    }
    class Teacher : Person
    {
        string Name;
        public Teacher(String name) : base(name)
        {
            this.Name = name;
        }
        public void Explian()
        {
            Console.WriteLine("Teacher is explaining");
        }
    }
    class read_name
    {
        public static void Main()
        {
            string name;
            name = Console.ReadLine();
            Student st = new Student(name);
            st.Study();
            name = Console.ReadLine();
            Teacher t = new Teacher(name);
            Console.ReadKey();
        }
    }
}






