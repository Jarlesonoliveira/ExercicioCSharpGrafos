using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bee_1029
{
    internal class Program
    {
        static int[] F;
        static int[] CF;

        static(int result, int count) calc(int n) {
            if (F[n] == -1) {
                (int result1, int count1) = calc(n - 1);
                (int result2, int count2) = calc(n - 2);

                F[n] = result1 + result2;
                CF[n] = count1 + count2 + 1;
            }
            return (F[n], CF[n]);
        }

        static void Main(string[] args) {
            F = new int[40];
            F[0] = 0;
            F[1] = 1;
            CF = new int[40];
            CF[0] = 1;
            CF[1] = 1;

            for(int i = 2; i < 40; i++) {
                F[i] = -1;
                CF[i] = -1;
            }

            int N = int.Parse(Console.ReadLine());
            for(int i = 0; i < N; i++) {
                int X = int.Parse(Console.ReadLine());
                (int result, int count) = calc(X);
                Console.WriteLine($"fib({X}) = {count - 1} calls = {result}");
            }
        }
        
    }
}