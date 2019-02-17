using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1=1, i2=0, i3=0, i4=0, i5=0, i6=0, z;

          
            while(i1<10)
            {
                while (i2 < 10)
                {
                    while (i3 < 10)
                    {
                        while (i4 < 10)
                        {
                            while (i5 < 10)
                            {
                                while (i6 < 10)
                                {
                                    z = i1 + i2 + i3 + i4 + i5 + i6;
                                    
                                    if (z % 7 == 0)
                                        Console.WriteLine(i1+""+ i2 +""+ i3+"" + i4 +""+ i5 +""+ i6);
                                    i6++;
                                }
                                i6 = 0;
                                i5++;
                            }
                            i5 = 0;
                            i4++;
                        }
                        i4 = 0;
                        i3++;
                    }
                    i3 = 0;
                    i2++;
                }
                i2 = 0;
                i1++;
            }
            Console.ReadLine();
        }
    }
}
