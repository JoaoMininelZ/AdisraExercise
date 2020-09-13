using System;

namespace GolombIsSilverman {
    class Silverman {
        static int silverman(int num) {

            // Padrão.
            if (num == 1)
                return 1;

            // Recursão.
            return 1 + silverman(num - silverman(silverman(num - 1)));
        }


        // Printa o primeiro numero na sequencia.
        static void printSilverman(int n) {
            // Definindo os números da sequencia.
            for (int i = 1; i <= n; i++)
                Console.Write(silverman(i) + " ");
        }

        // Codigo driver.
        static void Main() {

            int num = 10;

            printSilverman(num);

        }
    }
}

