using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lehava.Tasks.Entities
{
    public delegate int GetSizeFunc(string str);
    public class Work
    {                  
        public void Run(GetSizeFunc func1)
        {
            Console.WriteLine(func1("sdfsdf"));
        }
    }

    public class WorkString
    {
        public int GetSizeOf2String(string str)
        {
            return 2 * str.Length;
        }
        public int GetSizeOfString(string str)
        {
            return str.Length;
        }

        public void MyWork()
        {
            GetSizeFunc a = GetSizeOf2String;
            a("123");

            Work b = new Work();
            b.Run(GetSizeOfString);
            b.Run(GetSizeOf2String);
            b.Run(a);

        }

    }

}
