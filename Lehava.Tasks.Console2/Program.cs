using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lehava.Tasks.Console2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lehava.Tasks.Entities.WorkString workString = new Lehava.Tasks.Entities.WorkString();
            //workString.MyWork();

            Lehava.Tasks.Entities.HardWork hardWork = new Lehava.Tasks.Entities.HardWork();
            hardWork.Run();
        }
    }
}
