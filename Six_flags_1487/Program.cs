using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six_flags_1487
{
    internal class Program
    {

        public static int n;
        public static int[] v = new int[101];
        public static int[] p = new int[101];

        public static int dp(int n, int peso) {
            
            int[] pd = new int[peso + 1];
            for (int i = 0; i <= peso; i++) {
                for (int j = 0; j < n; j++) {
                    if (p[j] <= i) {
                        pd[i] = Math.Max(pd[i], pd[i - p[j]] + v[j]);
                    }
                }
            }

            return pd[peso];
        }

        internal static void Main() {
            int k = 1;
            int peso;
            string l;

            while (!(l = Console.ReadLine()).Equals("0 0")) {
                string[] tempVar = l.Split(' ');
                n = int.Parse(tempVar[0]);
                peso = int.Parse(tempVar[1]);

                for (int i = 0; i < n; i++) {
                string[] tempVar1 = (Console.ReadLine()).Split(' ');
                    p[i] = int.Parse(tempVar1[0]);                   
                    v[i] = int.Parse(tempVar1[1]);
                }
                Console.Write("Instancia {0:D}\n", k++);
                Console.Write("{0:D}\n\n", dp(n, peso));

            }

        }
    }
}