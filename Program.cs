using System;
namespace Kata {
    internal class Kata{
        
        class student {
            string name;
            string dob;
            public string Name{
                get { return name; }
                set { name = value; }
            }
            public string Dob{
                get { return dob; }
                set { dob = value; }
            }
        }
        static void Main(string[] args){
            student student = new student();
            student.Name = "Sheron";
            student.Dob = "1999-01-07";
           
            Console.WriteLine("Name is : "+student.Name+" DOB is : "+student.Dob);
        }
    }
}
