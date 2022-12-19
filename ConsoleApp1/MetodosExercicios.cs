using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class MetodosExercicios
    {
        public static decimal ConverteDeRealParaDolar(decimal valor)
        {

            return valor * (decimal)5.36;
        }

        public static string MostraNumero(string numeros)
        {
            var numerofinal = "";
            var contador = 0;

            string buscastr = numeros;

            for (int i = 0; i < buscastr.Length; i++)
            {
                int num = buscastr.Count(x => x == numeros[i]);

            if (contador < num)
            {
                numerofinal = numeros[i].ToString();
                }
        }
            return numerofinal;

        }

        public static void ExPalindromoCorrecao()
        {
            bool c = false;
            while (!c)
            {
                Console.WriteLine("Digite o palindromo inicial(fim para terminar): ");
                string palindromo = Console.ReadLine();
                if (palindromo.Length < 100)
                {
                    if (palindromo.Equals("fim"))
                        c = true;
                    else
                    {
                        Console.WriteLine("Maior palíndromo é: " + PrimeiraIterarcao(palindromo));
                    }


                }
            }
        }

        public static string PrimeiraIterarcao(string frase)
        {
            string novafrase = "";
            int tamanhofrase = frase.Length - 1;

            for (int i = 0; i < tamanhofrase; i++)
            {
                for (int z = i + 2; z < tamanhofrase; z++)
                {
                    if (z - i > novafrase.Length)
                    {
                        string frasecortada = frase.Substring(i, z - i);

                        if (SegundaIteracao(frasecortada))
                        {
                            if (frasecortada.Length > novafrase.Length)
                                novafrase = frasecortada;
                               // frase.Remove(i, z - i);
                        }
                    }
                }
            }
            novafrase.Remove(0);
            return novafrase;
        }

        public static bool SegundaIteracao(string word)
        {
            int l = 0;
            int z = word.Length - 1;
            while (z > l)
            {
                if (word[l] != word[z])
                {
                    return false;
                }
                ++l;
                --z;
            }
            return true;
        }

        public static int GolombRecursivo(int numero)
        {
            if (numero == 1)
                return 1;


            return 1 + GolombRecursivo(numero -
            GolombRecursivo(GolombRecursivo(numero - 1)));
        }
        public static void Golomb(int numero)
        {
            for (int i = 1; i <= numero; i++)
                Console.WriteLine(GolombRecursivo(i));
        }
    }

}
