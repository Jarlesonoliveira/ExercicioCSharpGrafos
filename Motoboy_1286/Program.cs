using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Motoboy_1286
{

    public class Pedido
    { 

        public int tempo;
        public int qnt;

        public Pedido() {
            this.tempo = 0;
            this.qnt = 0;

        }
    }
    internal class Program
    {
        public static void Main(string[] args) {
            
            Pedido[] pedidos = new Pedido[31];
            int[,] mtrz = new int[21, 31];

            for (int j = 0; j < pedidos.Length; j++) {
                pedidos[j] = new Pedido();
            }

            while (true) {
                int n = int.Parse(Console.ReadLine());
                if (n == 0) {
                    break;
                }

                int p = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++) {
                    string[] temp = (Console.ReadLine()).Split(' ');
                    pedidos[i].tempo = int.Parse(temp[0]);
                    pedidos[i].qnt = int.Parse(temp[1]);

                }

                for (int k = 0; k <= n; k++) {
                    for (int c = 0; c <= p; c++) {
                        if (k == 0 || c == 0) {
                            mtrz[k, c] = 0;
                        } else {
                            if (pedidos[k].qnt > c) {
                                mtrz[k, c] = mtrz[k - 1, c];
                            } else {
                                mtrz[k, c] = Math.Max(mtrz[k - 1, c - pedidos[k].qnt] + pedidos[k].tempo, mtrz[k - 1, c]);
                            }
                        }
                    }
                }

                Console.WriteLine(mtrz[n, p] + " min.");
                Console.ReadKey(true);
            }
        }
    }
}