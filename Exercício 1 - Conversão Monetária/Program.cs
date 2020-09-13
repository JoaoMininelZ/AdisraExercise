using System;
using System.Threading;

namespace ProcessoAdisra {
    class Program {
        static void Main() {
            double dolar = 5.36;

            Console.Write("Qual é a quantia em reais que você deseja converter para dólar americano? ");

            //armazena o valor de real pra posterior conversão.
            double.TryParse(Console.ReadLine(), out double real);

            //simples conversão em uma interpolação.
            Console.WriteLine($"A quantia de {real} convertida resulta em {real * dolar} dólares.");


        }
    }
}
