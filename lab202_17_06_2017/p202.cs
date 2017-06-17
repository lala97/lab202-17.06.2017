using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab202_17_06_2017
{
    class p202
    {
        public int sum(int a,int b)
        {
            int sum = 0;

            for (int i = a; i <= b; i++)
            {
                sum += i;
            }
            Console.WriteLine("sum=" + sum);

            return sum;
        }

        public double maas(double ayliq_gelir)

        {
            if (ayliq_gelir > 1000)
            {
                ayliq_gelir -= ayliq_gelir * 0.1;

            }
            else
            {
                ayliq_gelir -= ayliq_gelir * 0.05;
            }
            return ayliq_gelir;
        }
    }
}
