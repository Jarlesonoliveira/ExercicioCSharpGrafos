using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Xml.Linq;
using System.Diagnostics;
using System.ComponentModel;
using System.Collections;
using System.Reflection.Emit;
using System.Net.NetworkInformation;

namespace Grafos_1053
{
    internal class Program
    {
        static void Main(string[] args) {

            int T = int.Parse(Console.ReadLine());


            for (int i = 0; i < T; i++) {

                int N = int.Parse(Console.ReadLine());
                int[] L = new int[5] {1, 2, 3, 4, 5};
                char[] C = new char[5];
                C[0] = 'A';
                C[1] = 'B';
                C[2] = 'C';
                C[3] = 'D';
                C[4] = 'E';
                

                for (int e = 0; e < N; e++) {
                    string[] vet = Console.ReadLine().Split(' ');

                    string X1 = vet[0];
                    string Y1 = vet[1];

                    string[] vetor = X1.Split(C);                     

                    string letra = vetor[0];
                    string valor = vetor[1];

                    int valor1 = Convert.ToInt32(valor);                    

                    string[] vetor1 = Y1.Split(C);

                    string letra1 = vetor1[0];
                    string  valor2 = vetor1[1];                                      

                    int valor3 = Convert.ToInt32(valor2);                    

                    double letraValor1;
                    double letravalor2;                   
                                       

                    if (letra == "A") {
                        letraValor1 = C[0];
                    }
                    if (letra == ("B")) {
                        letraValor1 = C[1];
                    }
                    if (letra == ("C")) {
                        letraValor1 = C[2];
                    }
                    if (letra == ("D")) {
                        letraValor1 = C[3];
                    }
                    if (letra == ("E")) {
                        letraValor1 = C[4];
                    }


                    if (letra1 == "A") {
                        letraValor1 = C[0];
                    }
                    if (letra1 == ("B")) {
                        letraValor1 = C[1];
                    }
                    if (letra1 == ("C")) {
                        letraValor1 = C[2];
                    }
                    if (letra1 == ("D")) {
                        letraValor1 = C[3];
                    }
                    if (letra1 == ("E")) {
                        letraValor1 = C[4];
                    }

                    if (valor1 == 1) {
                        letravalor2 = L[0];
                    }
                    if (valor1 == 2) {
                        letravalor2 = L[1];
                    }
                    if (valor1 == 1) {
                        letravalor2 = L[2];
                    }
                    if (valor1 == 1) {
                        letravalor2 = L[3];
                    }
                    if (valor1 == 1) {
                        letravalor2 = L[4];
                    }

                    if (valor3 == 1 ) {
                        letravalor2 = L[0];
                    }
                    if (valor3 == 2) {
                        letravalor2 = L[1];
                    }
                    if (valor3 == 1) {
                        letravalor2 = L[2];
                    }
                    if (valor3 == 1) {
                        letravalor2 = L[3];
                    }
                    if (valor3 == 1) {
                        letravalor2 = L[4];
                    }
                    
                    var distance = Math.Sqrt(Math.Pow(valor1 - valor3, 2));                         
                    string resultado = letra + valor1;

                    if (X1 == resultado) {                         
                        Console.WriteLine("Case 1:" + distance);
                    }else if(Y1 == resultado) {
                        Console.WriteLine("Case 1:" + distance);                    
                    } else
                        Console.WriteLine("Case 2: ~x(");
                }
            }
            
        }

    }
}