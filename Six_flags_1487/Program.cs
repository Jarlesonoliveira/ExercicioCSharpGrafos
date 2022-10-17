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
            memset(pd, 0, sizeof(int));

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
            int peso;
            int k = 1;
            while (scanf("%d %d", n, peso) && n != 0) {
                for (int i = 0; i < n; i++) {
                    string tempVar = ConsoleInput.ScanfRead();
                    if (tempVar != null) {
                        p[i] = int.Parse(tempVar);
                    }
                    string tempVar2 = ConsoleInput.ScanfRead(" ");
                    if (tempVar2 != null) {
                        v[i] = int.Parse(tempVar2);
                    }
                }
                Console.Write("Instancia {0:D}\n", k++);
                Console.Write("{0:D}\n\n", dp(n, peso));
            }
        }
    }

}