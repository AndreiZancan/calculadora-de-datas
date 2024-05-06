using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraDeDatas
{
    public class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Linha();
            Console.WriteLine("Calculadora de Datas");
            Linha();
            Console.WriteLine("1 - Adicionar Dias");
            Console.WriteLine("2 - Adicionar Semanas");
            Console.WriteLine("3 - Adicionar Meses");
            Console.WriteLine("4 - Adicionar Anos");
            Console.WriteLine("5 - Sair");
            Linha();

            Console.Write("Digite uma opção: ");

            switch (Console.ReadLine().Trim())
            {
                case "1": Datas.AddDias(); break;

                case "2": Datas.AddSemanas(); break;

                case "3": Datas.AddMeses(); break;

                case "4": Datas.AddAnos(); break;

                case "5":
                    Console.Clear();
                    Linha();
                    Console.WriteLine("Fim do programa");
                    Linha();
                    Environment.Exit(0);
                    break;

                default:
                    Erro("\nDigite uma opção válida!");
                    break;
            }

            Console.WriteLine();
            Linha();

            Thread.Sleep(1000); // Delay de 1 segundo

            Console.WriteLine("Presione qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Show();
        }

        public static void Linha()
        {
            Console.WriteLine("---------------------------------------------------------");
        }

        public static void Erro(string texto)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(texto);
            Console.ResetColor();
        }
    }
}