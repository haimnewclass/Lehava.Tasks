using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lehava.Tasks.Entities
{
    internal class File
    {
        public void Run()
        {
            string fileName = @"C:\a\1.txt";

            // create file
            System.IO.File.WriteAllText(fileName, "*");
        }
    }
}
