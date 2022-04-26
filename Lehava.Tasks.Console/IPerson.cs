using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lehava.Tasks.Console
{
    internal interface IPerson
    {
       string GetName();
    }

    public class BallBase
    {
        int dd = 23;
        public int Price() { return 90; }
    }
    public class Ball:BallBase
    {
        int si = 123;
        public int Size() { return si; }
    }

    public class Balls
    {
        public void Add(int size)
        {

        }

        public List<Ball> list = new List<Ball>();
    }

    public class Student: IPerson
    {
        public int id;
        public string Name { get; set; }
        public string GetAddress()
        {
            return "***";
        }

        public string GetName()
        {
            return Name;
        }
    }


    public class Employee : IPerson
    {
        public string Name { get; set; }
        public int GetAge()
        {
            return 33;
        }

        public string GetName()
        {
            return Name;
        }
    }




}
