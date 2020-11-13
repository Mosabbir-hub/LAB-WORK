using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class student
    {
        private string id;
        private string name;
        private float cgpa;
        private string dept;

        public string Id
        {
            protected set { id = value; }
            get { return id; }

        }

        public string  Name
        {
            protected set { name = value; }
            get { return name; }

        }

        public float  Cgpa
        {
            protected set { cgpa = value; }
            get { return cgpa; }

        }

        public string Dept
        {
            protected set { dept = value; }
            get { return dept; }

        }
        
        public Student(string id)
        {
            this.id = id;
        }
        public void showInfo()
        {
            Id = "19-40432-1";
        }

    }
    static void Main(string[] args)
    {
        Student obj = new Student();
        obj.Name = "Hossain Mosabbir";
        obj.Id = "19-40432-1";
        obj.Dept = "CSE";
        obj.Cgpa = 3.00;

        Console.WriteLine("My name is : " + obj.Name);
        Console.WriteLine("My id is : " + obj.Id);
        Console.WriteLine("My cgpa is : " + obj.Cgpa);
        Console.WriteLine("My department is : " + obj.Dept);
    }

}
