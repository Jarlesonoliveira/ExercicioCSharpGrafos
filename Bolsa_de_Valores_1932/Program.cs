using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolsa_de_Valores_1932
{
    internal class Program
    {
        public static int retornasomamax(int[] a, int size, int c) {
            int total = 0;
            int atual = a[0];
            int venda = a[0];

            for (int i = 0; i < size; i++) {
                if (((atual - a[i] >= c)) || a[i] < venda) {
                    if (atual - venda - c > 0) {
                        total += atual - venda - c;
                    }
                    atual = venda = a[i];
                }
                if (a[i] > atual) {
                    atual = a[i];
                }
            }
            if (atual - venda - c > 0) {
                total += atual - venda - c;
            }
            return total;
        }

        internal static void Main() {
            int n;
            int custo;

            string input;
            List<string> s = new List<string>();

            while ((input = Console.ReadLine()) != null && input != "") {
                string[] tempVar = input.Split(' ');
                n = int.Parse(tempVar[0]);
                custo = int.Parse(tempVar[1]);
                int[] vet = new int[n];

                string[] tempVar1 = (Console.ReadLine()).Split(' ');
                for (int i = 0; i < n; ++i) {
                    vet[i] = int.Parse(tempVar1[i]);
                }
                Console.WriteLine(retornasomamax(vet, n, custo));
                Console.ReadKey();
            }
        }
    }
}