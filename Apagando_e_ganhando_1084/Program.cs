using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apagando_e_ganhando_1084
{
    internal class Program
    {
        public static void Main(string[] args) {
            string l;
            int N, D, t;  
            char[] numbers;
            char current;
            while (!(l = Console.ReadLine()).Equals("0 0")) {
                string[] aux = l.Split(' ');
                N = int.Parse(aux[0]);
                D = int.Parse(aux[1]);
                Stack<char> stack = new Stack<char>();
                numbers = Console.ReadLine().ToCharArray();
                t = N - D;
                for (int i = 0; i < N; i++) {
                    current = numbers[i];
                     
                    while (stack.Count() > 0 && stack.Count() + N - i > t && stack.Last() < current) {
                        stack.Pop();
                        
                    }
                    if (stack.Count() < t) {
                        stack.Push(current);
                    }
                }
                foreach (char number in stack.Reverse()) {
                    Console.Write(number);
                }
                Console.WriteLine();
            }
          Environment.Exit(0);
        }

    }

}