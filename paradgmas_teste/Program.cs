using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paradgmas_teste
{
    internal class Program
    {
        public static int n, days, costPerDay, revenue, resp;
        public static string line;
        public static int[] profitPerDay = new int[50];
        public static int[] aux = new int[50];

        public static void CalcMaxProfit() {
            aux[0] = Math.Max(0, profitPerDay[0]);

            for (int i = 1; i < days; i++) {
                aux[i] = Math.Max(profitPerDay[i] + aux[i - 1], Math.Max(0, profitPerDay[i]));
            }
            resp = aux.Max();
        }

        static void Main(string[] args) {
            while ((line = Console.ReadLine()) != null) {
                days = int.Parse(line);
                costPerDay = int.Parse(Console.ReadLine());

                for (int i = 0; i < days; i++) {
                    revenue = int.Parse(Console.ReadLine());
                    profitPerDay[i] = revenue - costPerDay;
                }

                CalcMaxProfit();
                Console.WriteLine(resp);
                Array.Clear(profitPerDay, 0, profitPerDay.Length);
                Array.Clear(aux, 0, aux.Length);
            }
        }
    }
}



namespace Ajude_seu_madruga_1912
{
    internal class Program
    {
        public static int[] v = new int[100006];
        public static int n;
        public static int area;
        public static int sum;

        public static double calc(double v2) {
            double ans = 0.0;
            for (int i = n - 1; i >= 0; --i) {
                if (v2 >= v[i]) {
                    return ans;
                }

                ans += (double)v[i] - v2;
            }
            return ans;
        }

        public static double bs() {
            double b = 0.0;
            double e = (double)v[n - 1];
            double mid;

            while (b <= e) {
                mid = (b + e) / 2.0;
                double c = calc(mid);

                if (Math.Abs(c - (double)area) < 0.0183156) {
                    return mid;
                }

                if (c < area) {
                    e = mid;
                } else {
                    b = mid;
                }

            }
            return -1;
        }
        internal static void Main() {
            char[] buf = new char[100];
            string l;
            while (!(l = Console.ReadLine()).Equals("0 0")) {
                string[] tempVar = l.Split(' ');
                n = int.Parse(tempVar[0]);
                area = int.Parse(tempVar[1]);
                sum = 0;

                string[] tempVar1 = (Console.ReadLine()).Split(' ');
                for (int i = 0; i < n; ++i) {
                    v[i] = int.Parse(tempVar1[i]);
                    sum += v[i];
                }

                if (sum < area) {
                    Console.WriteLine("-.-");
                } else if (sum == area) {
                    Console.WriteLine(":D");
                } else {
                    Array.Sort(v, 1, n);
                    buf = string.Format("{0:f4}", bs()).Distinct().ToArray();
                    Console.WriteLine(buf.Length.ToString("f4", CultureInfo.InvariantCulture));

                }


            }
        }
    }
}