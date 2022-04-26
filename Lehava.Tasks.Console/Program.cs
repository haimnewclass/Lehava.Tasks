using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lehava.Tasks.Console
{
    internal class Program
    {
        static string Name;
        
        static void DataStructure()
        {


            Ball ball = new Ball();
            BallBase ballBase = new BallBase();
            object o;

            o = ball;            
            o.ToString();
            ball.ToString();


            ball = (Ball) ballBase;
            ball.Price();
            


            int k1 = 123456789;
            int k2 = 123456689;
            int k3 = 123456690;


            Student[] studentList = new Student[99999];
            studentList[89] = null; //k1
            studentList[90] = null; //k2
            studentList[91] = null; //k3


            Student student = new Student();
            student.id = 123456789;
            studentList[56789] = student;
            student = studentList[123456789];


            Student student1 = new Student();
            Student student2 = new Student();

            Hashtable hashtable = new Hashtable();

            hashtable.Add(123456789, student1);
            hashtable.Add(123455789, student2);

            o = hashtable[123456789];
            //Ball a1  = (Ball) o;
            student1 = (Student)o;

            Dictionary<string, Student> students = new Dictionary<string, Student>();
            students.Add("sdfasdf", student1);
            students.Add("asdfsdgdf", student2);

            student = students["123123"];

            //   student1 = hashtable[123456789];


        }
        static int HashFunc(int fullKey)
        {
            int partialKey = fullKey; // Manipulation
            return partialKey;
        }

        static void Main(string[] args)
        {
            DataStructure();
            Student student1 = new Student();
            Student student2 = new Student();

            Employee employee = new Employee();
            employee.Name = "Avi";

            IPerson person = student1;
            person = employee;

            student1.Name = "Moshe";
            student2.Name = "Yaacov";

            employee.GetName();
            Print(person);
            Print(student1);
            Print(employee);

            int[] arr = { 1, 2, 43, 5, 6, 54, 34, 34, 53, 43, 453, 45, 345, 345, 34, 534, 534, 5 };
            foreach(int i in arr)
            {
                System.Console.WriteLine(i);
            }
        }

        static void Print(IPerson person)
        {
            System.Console.WriteLine(person.GetName());
        }


    }
}
