using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pontes_de_São_Petersburgo_1203
{
    internal class Program
    {
        public static int[] grau = new int[101];
        public static int[,] dp = new int[101, 10010];
        public static int possivel;
        public static int r;
        public static int k;
        public static int solve(int regiao, int restam) {
            if (possivel != 0) {
                return 1;
            }
            if (restam < 0 || regiao > r) {
                return 0;
            }
            if (restam == 0) {
                possivel = 1;
                return dp[regiao, restam] = 1;
            }
            if (dp[regiao, restam] != -1) {
                return dp[regiao, restam];
            }
            return dp[regiao, restam] = solve(regiao + 1, restam)
                != 0 || solve(regiao + 1, restam - grau[regiao]) != 0 ? 1 : 0;
        }
        static void Main(string[] args) {
            string input;
            List<string> s = new List<string>();

            while ((input = Console.ReadLine()) != null && input != "") {
                string[] tempVar = input.Split(' ');
                r = int.Parse(tempVar[0]);
                k = int.Parse(tempVar[1]);
                possivel = 0;
                for (int i = 1; i <= r; i++) {
                    grau[i] = 0;
                    for (int j = 0; j <= k; j++) {
                        dp[i, j] = -1;
                    }
                }
                int u;
                for (int i = 1; i <= k; i++) {
                int v;
                string[] tempVar1 = (Console.ReadLine()).Split(' ');
                    u = int.Parse(tempVar1[0]);
                    v = int.Parse(tempVar1[1]);
                    grau[u]++;
                    grau[v]++;
                }
            Console.Write("{0}\n", solve(1, k) != 0 ? 'S' : 'N');
            }
            Console.ReadKey();
        }
    }
}