using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucro_1310
{
    internal class Program
    {
        public static int dias, custoPorDia, receita, resp;
        public static string linha;
        public static int[] lucroPorDia = new int[50];
        public static int[] aux = new int[50];

        public static void calcMaxLucro() {
            aux[0] = Math.Max(0, lucroPorDia[0]);

            for (int i = 1; i < dias; i++) {
                aux[i] = Math.Max(lucroPorDia[i] + aux[i - 1], Math.Max(0, lucroPorDia[i]));
            }
            resp = aux.Max();
        }
        public static void Main(string[] args) {
            while ((linha = Console.ReadLine()) != null) {
                dias = Convert.ToInt32(linha);
                custoPorDia = int.Parse(Console.ReadLine());

                for(int i = 0; i < dias; i++) {
                    receita = int.Parse(Console.ReadLine());
                    lucroPorDia[i] = receita - custoPorDia;
                }
                calcMaxLucro();
                Console.WriteLine(resp);
                Array.Clear(lucroPorDia, 0, lucroPorDia.Length);
                Array.Clear(aux, 0, aux.Length);
            }
        
        }      
    }
}