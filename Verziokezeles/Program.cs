﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verziokezeles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem adjón meg 10 számót");
            int[] a = new int[10];
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Kérem a {0} ez a számót",i+1);
                a[i] = Convert.ToInt32(Console.ReadLine());


            }
            int b=a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > b)
                {
                    b = a[i];
                } 
                
            }
            Console.WriteLine("A legnagyobb szám {0}",b);
            Console.ReadKey();
        }
    }
}
