using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13jan_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Cricket c1 = new Cricket();
            Cricket c2 = new Cricket();
            Cricket c3 = new Cricket();
            Cricket c4 = new Cricket();
            Cricket c5 = new Cricket();
            Cricket c6 = new Cricket();
            c1.name = "Shakib Al Hasan";
            c1.wickets = 260;
            c2.name = "Mashrafe Bin Mortaza";
            c2.wickets = 270;
            c3.name = "Mahmudullah Riyad";
            c3.wickets = 76;
            c4.name = "Rubel Hossain";
            c4.wickets = 126;
            c5.name = "Taijul Islam";
            c5.wickets = 12;
            c6.name = "Ahmed Mahir Shoaib";
            c6.wickets = 535;
            c1.Show();
            c2.Show();
            c3.Show();
            c4.Show();
            c5.Show();
            c6.Show();
            Console.ReadLine();

        }
    }
}
