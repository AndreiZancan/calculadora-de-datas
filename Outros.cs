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
            int numero = 0;

            bool erro;

            while (true)
            {
                try
                {
                    Console.Write(texto);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    numero = int.Parse(Console.ReadLine().Replace(".", ",").Trim()); // tenta converter para inteiro
                    Console.ForegroundColor = ConsoleColor.White;
                    erro = false;
                }
                catch
                {
                    erro = true;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n Erro! Digite um número válido!\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                if (numero < 0 && erro == false)
                {
                    erro = true;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n Erro! Digite um número válido!\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                if (erro == false && numero >= 0)
                {
                    break;
                }
            }
            return numero;
        }
    }
}