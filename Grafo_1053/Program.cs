using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos_1053
    {
        internal class Program
        {
            static void Main(string[] args) {

                int T = int.Parse(Console.ReadLine());
                

                for (int i = 0; i < T; i++) {

                    int N = int.Parse(Console.ReadLine());

                    for (int j = 0; i < N; i++) {

                        string[] vet = Console.ReadLine().Split(' ');

                        double X1 = double.Parse(vet[0]);
                        double Y1 = double.Parse(vet[1]);

                        if (X1 >= 1 && X1 <= 5) {

                            Console.WriteLine("Case 1: " + X1);

                        } else if (Y1 >= 1 && Y1 <= 5) {

                            Console.WriteLine("Case 1: " + Y1);
                        } else {

                            Console.WriteLine("Case 2: ~x(");
                        }
                    }

                }
            }
        }
    }