using System;
using System.Linq;

namespace Lanchonete {
    class Program {
        static void Main() {
            double total = 0;
            string resposta;
            double carne = 20, frango = 16, batata = 6, refri = 4;
            string complemento;


            var cardapio = new string[] { "1 - lanche de carne", "2 - lanche de frango", "3 - batata frita", "4 - Refrigerante" };
            var aceitar = new string[] { "s", "sim", "yes" };
            var negar = new string[] { "n", "nao", "não", "no"};

            Console.WriteLine("Bem vindo a lanchonete ");
            foreach (var item in cardapio) {
                Console.WriteLine(item);
            }
            do {
                Console.Write("digite o número item que você deseja  ");
                double.TryParse(Console.ReadLine(), out double entrada);

                if (entrada == 1) {
                    Console.WriteLine("Quantos você deseja?");
                    Int32.TryParse(Console.ReadLine(), out int multiply);
                    Console.WriteLine("Quer com salada?(S/N)");
                    complemento = Console.ReadLine();
                    if (aceitar.Contains(complemento)) {
                        carne += 2;
                    }
                    else if (negar.Contains(complemento)) {
                        
                    } else {
                        Console.WriteLine("q?"); 
                    }
                    Console.WriteLine("Quer com maionese?(S/N)");
                    complemento = Console.ReadLine();
                    if (complemento.ToLower() == "s") {
                        carne += 1;
                    }

                    total += carne * multiply;
                } else if (entrada == 2) {
                    Console.WriteLine("Quantos você deseja?");
                    Int32.TryParse(Console.ReadLine(), out int multiply);
                    Console.WriteLine("Quer com salada?(S/N)");
                    complemento = Console.ReadLine();
                    if (complemento.ToLower() == "s") {
                        frango += 2;
                    }
                    Console.WriteLine("Quer com maionese?(S/N)");
                    complemento = Console.ReadLine();
                    if (complemento.ToLower() == "s") {
                        frango += 1;
                    }
                    total += frango * multiply;

                } else if (entrada == 3) {
                    Console.WriteLine("Quantos você deseja?");
                    Int32.TryParse(Console.ReadLine(), out int multiply);
                    Console.WriteLine("Quer com maionese?(S/N)");
                    complemento = Console.ReadLine();
                    if (complemento.ToLower() == "s") {
                        batata += 1;
                        total += batata * multiply;
                    }
                } else if (entrada == 4) {
                    Console.WriteLine("Quantos você deseja?");
                    Int32.TryParse(Console.ReadLine(), out int multiply);
                    total += refri * multiply;
                } else {
                    Console.WriteLine("Não entendi, escreva o número do item novamente por favor.");
                        

                }
                Console.WriteLine("Deseja mais alguma coisa? (S/N)");
                resposta = Console.ReadLine();

                continue;


            } while (resposta.ToLower() == "s");

            Console.WriteLine($"o valor total deu {total} reais.");



        }
    }
}
