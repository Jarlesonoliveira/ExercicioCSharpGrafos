using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torre_de_Hanoi__Novamente_1166
{
    internal class Program
    {
        public static int issquare(int x) {
            return (int)Math.Round(Math.Sqrt(x))
                * (int)Math.Round(Math.Sqrt(x)) == x ? 1 : 0;
        }
        static void Main(string[] args) {
            int t;
            t = int.Parse(Console.ReadLine());

            while ((t--) != 0) {
                int[] pegs = new int[51]; 
                int n;
                n = int.Parse(Console.ReadLine());
                int j = 1;
                if (n == 1) {
                    Console.WriteLine(1);
                    continue;
                }
                bool finished = false;

                while (!finished) {
                    for (int i = 0; i <= n; i++) {
                        if (issquare(j + pegs[i]) != 0 || pegs[i] == 0) {
                            pegs[i] = j;
                            j++;
                            i = 0;
                        }
                        if (i == n) {
                            Console.WriteLine(j - 1);
                            finished = true;
                        }
                    }
                }                    
            }
            Console.ReadKey();
        }
    }
}