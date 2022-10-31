using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using System.Runtime.InteropServices;

namespace Cortando_Canos_1798
{
    internal class Program
    {
        public static int[,] dp = new int[1005,2005];
        public static int n;
        public static int[] valor = new int[1005];
        public static int[] pesos = new int[1005];
        public static int calc(int i, int peso) {
            if (i == n) {
                return 0;
            }
            if (peso == 0) {
                return 0;
            }
            if (peso < 0) {
                return -9999999;
            }
            ref int ans = ref dp[i,peso];

            if (ans == 0) {                
                ans = Math.Max(calc(i + 1, peso), valor[i] + calc(i, peso - pesos[i]));
            }
            return ans;
        }
        public static void Main() {            
            int pmax;
            string input;
            List<string> s = new List<string>();

            while ((input = Console.ReadLine()) != null && input != "") {               
                string[] tempVar = input.Split(' ');
                n = int.Parse(tempVar[0]);
                pmax = int.Parse(tempVar[1]); 

                for (int i = 0; i < n; ++i) {
                    string[] tempVar1 = (Console.ReadLine()).Split(' ');
                    pesos[i] = int.Parse(tempVar1[0]);
                    valor[i] = int.Parse(tempVar1[1]);
                }                
                Array.Clear(dp, 0, dp.Length);
                Console.Write(calc(0, pmax));
                Console.Write('\n');

                Console.ReadKey();
            }
        }
    }
}