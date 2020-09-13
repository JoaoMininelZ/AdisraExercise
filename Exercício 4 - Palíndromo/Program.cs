using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace PalindromicCSharp {
    class Program {
        static void Main(string[] args) {
            Boolean c = false;
            while (!c) {
                Console.WriteLine("Digite o palindrome inicial(fim para terminar): ");
                String s = Console.ReadLine();
                if (s.Length < 100) {
                    if (s.Equals("fim"))
                        c = true;
                    else
                        Console.WriteLine("Maior palíndrome é: " + maiorPalin(s));
                } else
                    Console.WriteLine("A cadeia de caracteres precisa ter no máximo 100 elementos");


                static void printSubStr(string entrada, int menor,
                                        int maior) {
                    Console.WriteLine(entrada.Substring(menor, maior - menor + 1));
                }

                // esta função imprime o maior palindromo da substring e também retorna o tamanho do maior palindromo.
                static int maiorPalin(string entrada) {

                    // Recebe o tamanho do texto digitado
                    int n = entrada.Length; 

                    //a tabela retornara um valor falso se a string de entrada não for um palindromo.
                    bool[,] tabela = new bool[n, n];

                    // Este bloco torna toda string de tamanho 1 verdadeira. 
                    int tamanho = 1;
                    for (int i = 0; i < n; ++i)
                        tabela[i, i] = true;

                    // Verifica se a substring tem tamanho igual a 2. 
                    int inicio = 0;

                    for (int i = 0; i < n - 1; ++i) {
                        if (entrada[i] == entrada[i + 1]) {
                            tabela[i, i + 1] = true;
                            inicio = i;
                            tamanho = 2;
                        }
                    }

                    // Verifica se o tamanho é maior que 2.
                    for (int t = 3; t <= n; ++t) {

                        // arrumar o indice inicial
                        for (int i = 0; i < n - t + 1; ++i) {

                            // recebe o indice final da substring do começo do indice i e tamanho t.
                            int j = i + t - 1;

                            //Este bloco de código confere se a linha de cód do indice de i até o indice de j é um palíndromo.
                            if (tabela[i + 1, j - 1] && entrada[i] == entrada[j]) {
                                tabela[i, j] = true;
                                if (t > tamanho) {
                                    inicio = i;
                                    tamanho = t;
                                }
                            }
                        }
                    }
                    Console.Write("O maior palíndromo da substring é : ");
                    printSubStr(entrada, inicio, inicio + tamanho - 1);

                   // auto explicativo.
                    return tamanho;
                }


            }
        }
    }

}
