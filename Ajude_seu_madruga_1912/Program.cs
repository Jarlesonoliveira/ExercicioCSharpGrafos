using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Ajude_seu_madruga_1912
{
    internal class Program
    {
        internal static void Main() {
            int[] v = new int[100006];
            int sum;
            int n;
            double area;
            string l;
            Stopwatch sw = new Stopwatch();
            
            while (!(l = Console.ReadLine()).Equals("0 0")) {
                string[] tempVar = l.Split(' ');
                n = int.Parse(tempVar[0]);
                area = int.Parse(tempVar[1]);
                sum = 0;
                sw.Start();
                string[] tempVar1 = new string[n-1];
                tempVar1 = (Console.ReadLine()).Split(' ');
                
                for (int i = 0; i < n; ++i) {
                    v[i] = int.Parse(tempVar1[i]);
                    sum += v[i];
                }

                if (area > sum) {
                    Console.WriteLine("-.-\n");

                } else if (area == sum) {
                    Console.WriteLine(":D\n");
                } else {
                    double b = 0.0;
                    double e = 10000.0;
                    double mid = 0;
                    
                    while (b <= e) {
                        mid = (b + e) / 2.0;
                        double cut = 0;
                        for (var i = 0; i < v.Length; i++) {
                            if (v[i] > mid) {
                                cut += v[i] - mid;
                            }
                        }
                        double thres = (area - cut);
                        if (Math.Abs(thres) < 0.00001) {
                            break;
                        }
                        if (cut < area) {
                            e = mid;
                        } else {
                            b = mid;
                        }
                    }
                    Array.Sort(v, 1, n);
                    Console.WriteLine(mid.ToString("f4", CultureInfo.InvariantCulture));
                    sw.Stop();
                    Console.WriteLine("Tempo gasto : " + sw.ElapsedMilliseconds.ToString() + " milisegundos");
                }                
            }
        }
    }
}