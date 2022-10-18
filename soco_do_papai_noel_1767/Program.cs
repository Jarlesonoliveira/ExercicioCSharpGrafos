using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saco_do_papai_noel_1767
{
    internal class Program
    {
        public static int[] result = new int[51];
        public static int[] pacotes = new int[51];

        public static void Main(string[] args) {

            int T = int.Parse(Console.ReadLine());
            int pac;
            int quantidade;
            int peso;
            int pac2;

            while (T-- != 0) {
                result[0] = 0;
                pacotes[0] = 0;
                for (int j = 1; j <= 50; j++) {
                    result[j] = -1;
                    pacotes[j] = 0;
                }
                pac = int.Parse(Console.ReadLine());
                pac2 = pac;
                while (pac-- != 0) {
                    string[] tempVar1 = (Console.ReadLine()).Split(' ');
                    quantidade = int.Parse(tempVar1[0]);
                    peso = int.Parse(tempVar1[1]);

                    for (int i = 50; i >= 0; i--) {
                        if (result[i] != -1) {
                            if (i + peso <= 50) {
                                if (result[i + peso] < result[i] + quantidade) {
                                    result[i + peso] = result[i] + quantidade;
                                    pacotes[i + peso] = pacotes[i] + 1;
                                }
                            }
                        }
                    }
                }

                int valor = 0;
                int pos = 0;
                for (int i = 0; i < 51; i++) {
                    if (result[i] > valor) {
                        valor = result[i];
                        pos = i;
                    }
                }

                Console.WriteLine(valor + " brinquedos");
                Console.WriteLine("Peso: " + pos + " kg");
                Console.WriteLine("sobra(m) " + (pac2 - pacotes[pos]) + " pacote(s)");
                Console.WriteLine("");

            }
        }
    }
}