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
            
            int c;

            string g;

            do
            {
                Console.WriteLine("Kérem adja meg a tömb hózzsát");
                g = Console.ReadLine();
            } while (int.TryParse(g, out c) == false);
           





            Console.WriteLine("Kérem adjón meg 10 számót");
            int[] a = new int[c];


                int l=0;

                string w;

                do
                {
                    
                    Console.WriteLine("Kérem a {0} ez a számót", l + 1);
                    w = Console.ReadLine();
                    if(int.TryParse(w, out a[l]) == true)
                {
                    l++;
                }

                } while (l<c);

                
               
                
            
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
