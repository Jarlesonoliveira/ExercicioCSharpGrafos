using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troco_2446
{
    internal class Program
    {
        static void Main(string[] args) {

            int v;
            int n = 0;
            bool[] dp = new bool[100001];

            string[] tempVar1 = (Console.ReadLine()).Split(' ');
            v = int.Parse(tempVar1[0]);
            n = int.Parse(tempVar1[1]);

            int[] coins = new int[n + 1];

            string[] tempVar2 = (Console.ReadLine()).Split(' ');
            for (int i = 0; i < n; i++) {
                coins[i] = int.Parse(tempVar2[i]);
            }           

            dp[0] = true; 

            for (int j = 0; j < n; j++) {
                for (int i = v; i >= 0; i--) {
                    if (dp[i] && i + coins[j] <= v)
                        dp[i + coins[j]] = true;
                }
            }
            Console.WriteLine(dp[v] ? 'S' : 'N');
            Console.ReadKey();
        }
    }
}