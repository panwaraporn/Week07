using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{

    class Program
    {
        static void Main(string[] args)
        {
            //Student su = new Student("Student Name", "12345678");
            StudentID su = new StudentID("StudentID", 123456789)
            try
            {
                //su.Name = "My name";
                su.salary = 300.0f;
                //Console.WriteLine("Student name : " + su.Name);
                Console.WriteLine("StudentID   : " + su.StudentID);
                Console.WriteLine("salary  : " + su.salary);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
    class Student
    {
      //  private string name;
        private string id;
        private float salary;

        public Student(string StudentID, string salary)
        {
            this.StudentID = StudentID;   // assign auto variable to the field
            this.salary = salary;
        }

        public string StudentID
        {
            get { return StudentID; }
        }
     //   public string ID
        {
       //     get { return id; }
        //}
        public float salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value > 300.0 && value <= 450.0)
                    salary = value;
                else
                    throw (new Exception("Error!!!! invalid salary"));
            }
        }
    }

}
