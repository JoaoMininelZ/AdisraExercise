using System;
using System.Collections.Generic;
using System.Linq;

class Class2 {
    static void Main() {
        double[] numeros = { 1, 2.15, 1, 3, 1, 4, 5, 2.15 };

        List<double> listaNumerica = new List<double>(numeros);

        var freqs = ReceberFreq(listaNumerica);
        DisplaySortedFrequencies(freqs);

    }

    static Dictionary<double, int> ReceberFreq(List<double> numeros) {
        var resultado = new Dictionary<double, int>();
        foreach (double numero in numeros) {
            if (resultado.TryGetValue(numero, out int count)) {

                resultado[numero] = count + 1;
            } else {

                //seta o valor para 1.
                resultado.Add(numero, 1);
            }
        }

        return resultado;
    }

    static void DisplaySortedFrequencies(Dictionary<double, int> frequencias) {

        // Ordena os pares no dictionary da maior para a menor frequencia.
        var classificacao = from par in frequencias
                     orderby par.Value descending
                     select par;

        // Printa todos os resultados ordenados.
        foreach (var par in classificacao) {
            Console.WriteLine($"{par.Key} = {par.Value}");
        }
    }
}