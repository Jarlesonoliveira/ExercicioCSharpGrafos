using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Grafos_1053
{
    internal class Program
    {
        static void Main(string[] args) {

            int T = int.Parse(Console.ReadLine());


            for (int i = 0; i < T; i++) {

                int N = int.Parse(Console.ReadLine());

                for (int e = 0; e < N; e++) {

                    char A = 'A'; int A1 = 1 ^ 5;
                    char B = 'B'; int B2 = 1 ^ 5;
                    char C = 'C'; int C3 = 1 ^ 5;
                    char D = 'D'; int D4 = 1 ^ 5;
                    char E = 'E'; int E5 = 1 ^ 5;

                    string[] vet = Console.ReadLine().Split(' ');

                    double X1 = double.Parse(vet[0]);
                    double X2 = double.Parse(vet[1]);

                    double total = X1 + X2;

                    if (total == A || total == A1) {
                        Console.WriteLine("Case 1: " + total);
                        total++;
                    } else if (total == B || total == B2) {
                        Console.WriteLine("Case 1: " + total);
                        total++;
                    } else if (total == C || total == C3) {
                        Console.WriteLine("Case 1: " + total);
                        total++;
                    } else if (total == D || total == D4) {
                        Console.WriteLine("Case 1: " + total);
                        total++;
                    } else if (total == E || total == E5) {
                        Console.WriteLine("Case 1: " + total);
                        total++;
                    } else {

                        Console.WriteLine("Case 2: ~x(");
                    }
                }
             
            }
        }
    }
}

