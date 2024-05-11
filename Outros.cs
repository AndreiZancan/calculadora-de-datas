using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraDeDatas
{
    public class Outros
    {
        public static int LerInt(string texto)
        {
            int numero;
            bool entradaValida = false;

            do
            {
                Console.Write(texto);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                string input = Console.ReadLine().Trim();
                Console.ResetColor();

                if (int.TryParse(input, out numero) && numero >= 0)
                {
                    entradaValida = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n Erro! Digite um número válido!\n");
                    Console.ResetColor();
                }
            } while (!entradaValida);

            return numero;
        }
    }
}