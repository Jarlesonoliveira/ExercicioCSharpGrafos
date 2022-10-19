using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercio__de_Vinhos_na_Gergovia_1661
{
    internal class Program
    {
        static void Main(string[] args) {
            string l;
            int n;
            long trabalho;
            while (!(l = Console.ReadLine()).Equals("0")) {
                string[] tempVar = l.Split(' ');
                n = int.Parse(tempVar[0]);
                int[] a = new int[n];

                string[] tempvar1 = (Console.ReadLine()).Split(' ');//o split fora do for ele não repet as vezes
                for (int i = 0; i < n; i++) {
                    a[i] = int.Parse(tempvar1[i]);
                }

                trabalho = 0;

                for (int i = 1; i < n; i++) {
                    trabalho += Math.Abs(a[i - 1]);
                    a[i] += a[i - 1];
                }

                Console.Write(trabalho);
                Console.Write("\n");
            }
        }
    }
}