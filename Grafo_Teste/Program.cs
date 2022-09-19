﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafo_teste
{
    public class Program
    {
        static void Main(string[] args) {
            
            if (args.Length == 0) { args = new string[] { "3", "43", "6" }; }
            IEnumerator<int> sc = (from arg in args select int.Parse(arg)).GetEnumerator();
            while (sc.MoveNext()) {
                int Numero_de_dias;
                int Custo_por_dia;
                var lucro = 0;
                int soma;
                Numero_de_dias = (int)Convert.ToInt64(Console.ReadLine());
                Custo_por_dia = (int)Convert.ToInt64(Console.ReadLine());
                int[] receita = new int[Numero_de_dias];
                for (int c = 0; c < receita.Length; c++) {
                    receita[c] = (int)Convert.ToInt64(Console.ReadLine());
                }
                var i = 0;
                int contagem_dia;
                int Lucro_temporario;
                while (i < receita.Length) {
                    Lucro_temporario = 0;
                    contagem_dia = 0;
                    soma = 0;
                    for (int c = i; c < receita.Length; c++) {
                        soma = soma + receita[c];
                        contagem_dia++;
                        Lucro_temporario = soma - (contagem_dia * Custo_por_dia);
                        if (lucro < Lucro_temporario) {
                            lucro = Lucro_temporario;
                        }
                    }
                    i++;
                }
                Console.WriteLine(lucro);
            }
        }
    }
}