﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Maffs maffs = new Maffs();

            Console.WriteLine("Please enter an integer.");
            int answer1 = maffs.maff(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Answer was {0}.", answer1);

            Console.WriteLine("Please enter a decimal.");
            int answer2 = maffs.maff(Convert.ToDecimal(Console.ReadLine()));
            Console.WriteLine("Answer was around {0}.", answer2);

            Console.WriteLine("Please enter an integer.");
            int answer3 = maffs.maff(Console.ReadLine());
            Console.WriteLine("Answer was {0}.", answer3);
            Console.ReadLine();
        }
    }
}
