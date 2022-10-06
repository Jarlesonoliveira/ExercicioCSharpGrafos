using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canhao_de_destruicao_1288
{
    internal class Program
    {
        public static int mochila(int capacidade_max, int[] peso, int[] val, int n) {
            int i, j;
            int[,] capacidade_mochila = new int[n + 1, capacidade_max + 1];

            for (i = 0; i <= n; i++) {
                for (j = 0; j <= capacidade_max; j++) {
                    if (i == 0 || j == 0) {
                        capacidade_mochila[i, j] = 0;
                    } else if (peso[i - 1] <= j) {
                        capacidade_mochila[i, j] = Math.Max(val[i - 1] + capacidade_mochila[i - 1, j - peso[i - 1]], capacidade_mochila[i - 1, j]);
                    } else {
                        capacidade_mochila[i, j] = capacidade_mochila[i - 1, j];
                    }
                }
            }

            return capacidade_mochila[n, capacidade_max];
        }

        public static void Main(string[] args) {

            int casos_testes = int.Parse(Console.ReadLine());
            while (casos_testes > 0) {
                int n, k, r;                       
                int i, x, y, capacidade;                

                string[] tempVar2 = (Console.ReadLine()).Split(' ');
                n = int.Parse(tempVar2[0]);

                int[] vet_poder = new int[n + 1];                
                int[] vet_peso = new int[n + 1];

                for (i = 0; i < n; i++) {
                    string[] tempVar3 = (Console.ReadLine()).Split(' ');
                    x = int.Parse(tempVar3[0]);
                    y = int.Parse(tempVar3[1]);


                    vet_poder[i] = x;
                    vet_peso[i] = y;
                }

                    string[] tempVar5 = (Console.ReadLine()).Split(' ');
                    k = int.Parse(tempVar5[0]);

                    string[] tempVar6 = (Console.ReadLine()).Split(' ');
                    r = int.Parse(tempVar6[0]);
                

                capacidade = mochila(k, vet_peso, vet_poder, n);
                if (capacidade >= r) {
                    Console.Write("Missao completada com sucesso\n");
                } else {
                    Console.Write("Falha na missao\n");
                }
                casos_testes--;
            }
            Console.ReadKey();
        }
    }
}