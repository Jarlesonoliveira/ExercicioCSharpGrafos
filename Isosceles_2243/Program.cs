using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isosceles_2243
{
    internal class Program
    {
        static void Main(string[] args) {

            int N;
            int resposta;
            int[] colunas = new int[50001];
            int[] esquerda = new int[50001];
            int[] direita = new int[50001];

            N = int.Parse(Console.ReadLine());
                string[] tempVar = (Console.ReadLine()).Split(' ');
            for (int i = 0; i < N; ++i) {
                colunas[i] = int.Parse(tempVar[i]);
            }

            esquerda[0] = 1;
            for(int i = 1; i < N; i++) {
                esquerda[i] = Math.Min(colunas[i], esquerda[i - 1] + 1);
            }
            direita[N - 1] = 1;
            for(int i = N - 2; i > -1; --i) {
                direita[i] = Math.Min(colunas[i], direita[i + 1] + 1);
            }

            resposta = 0;
            for (int i = 0; i < N; ++i) {
                resposta = Math.Max(resposta, Math.Min(esquerda[i], direita[i]));
            }
            Console.WriteLine(resposta);
            Console.ReadKey();
        }
    }
}