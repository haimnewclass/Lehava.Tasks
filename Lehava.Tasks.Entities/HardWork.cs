using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lehava.Tasks.Entities
{
    public class HardWork
    {
        public void MyAction()
        {
            Random random = new Random();
            int sumn = 0;
            for (int i = 0; i < 10; i++)
            {
                sumn += random.Next(1, 10);
                System.Threading.Thread.Sleep(1000);
            }
        }

        public void Run()
        {
            Action a = MyAction;

            Task task2 = Task.Factory.StartNew(() =>
            {
                Random random = new Random();
                int sumn = 0;
                for (int i = 0; i < 10; i++)
                {
                    sumn += random.Next(1, 10);
                    System.Threading.Thread.Sleep(1000);
                }
            });

            Task task = Task.Factory.StartNew(a);

            while (task.Status!=TaskStatus.RanToCompletion)
            {
                System.Threading.Thread.Sleep(1000);
            }
            
        }
    }
}
