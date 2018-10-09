using System;
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
            Console.WriteLine("Kérem adja meg a tömb hózzsát");
            int c;

            string g = Console.ReadLine();


            if (int.TryParse(g, out c) == true)
            {


            }
            else
            {
                Console.WriteLine("HIBA");
                Console.ReadKey();
                return;
            }





            Console.WriteLine("Kérem adjón meg 10 számót");
            int[] a = new int[c];
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Kérem a {0} ez a számót", i + 1);

                string w = Console.ReadLine();
               
                
                if(int.TryParse(w,out a[i])==true)
                {
                    

                }else
                {
                    Console.WriteLine("HIBA");
                    Console.ReadKey();
                    return;
                }

            }
            int b=a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > b)
                {
                    b = a[i];
                } 
                
            }
            int d = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < d)
                {
                    d = a[i];
                }

            }
            Console.WriteLine("A legnagyobb szám {0}",b);
            Console.WriteLine("A legkisseb szám {0}", d);
            Console.ReadKey();
        }
    }
}
