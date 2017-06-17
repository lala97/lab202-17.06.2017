using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab202_17_06_2017
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
         //   int b = Convert.ToInt32(Console.ReadLine());

            p202 my_class_name = new p202();
            //   my_class_name.sum(a, b);
            double result = my_class_name.maas(a);
            Console.WriteLine(result);
            


            Console.ReadKey();
           
          

            //if (5>3)
            //{
            //    Console.WriteLine("duzdur");
            //}
            //else
            //{
            //    Console.WriteLine("sehvdir");
            //}
        }
    }
}
