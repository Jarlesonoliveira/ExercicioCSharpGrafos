using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Festival_de_estatuas_de_gelo_1034
{
    internal class Program
    {

        public static int[] pd = new int[1000001];
        public static int Calcula(int[] valores, int n, int m) {
            int i, j, k;
            
            if (m % valores[n - 1] == 0) {
                return m / valores[n - 1];
            }

            pd[0] = 0;
            for (int c = 1; c <= m; c++) {
                pd[c] = 500000000;
            }

            for (i = 0; i < n; i++) {
                k = valores[i];
                for (j = k; j <= m; j++) {
                    pd[j] = Math.Min(pd[j], pd[j - k] + 1);
                }
            }

            return pd[m];
        }

        internal static void Main() {
            int blocos;

            int t = int.Parse(Console.ReadLine());
            for (int i = 1; i <= t; i++) {
                string[] vet = (Console.ReadLine()).Split(' ');
                int n = int.Parse(vet[0]);
                int m = int.Parse(vet[1]);
                string[] temp = (Console.ReadLine()).Split(' ');
                int[] valores = new int[temp.Length];
                for (int j = 0; j < temp.Length; j++) {
                    valores[j] = int.Parse(temp[j]);
                }

                Array.Sort(valores);                
                blocos = Calcula(valores, n, m);
                Console.WriteLine(blocos);                
                
            }
            Console.ReadKey();
        }
    }
}