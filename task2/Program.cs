using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1
{
    class Student
    {
        private string name;
        public string Name
{
            get;
            set;
}
        public string id;
        public int yearofstudy;

        public Student(string name,int yearofstudy) { this.name = name;this.yearofstudy = yearofstudy; }
       
        public void Getinfo()
        {
            Console.WriteLine(name + " "+ yearofstudy);
        }
        public void increase(){
            yearofstudy++;
}
}
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Student idk = new Student(Console.ReadLine(),Console.ReadLine());
            idk.Getinfo();
            Console.ReadKey();
        }
    }
}