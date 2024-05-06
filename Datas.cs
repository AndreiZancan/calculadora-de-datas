using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace CalculadoraDeDatas
{
    public class Datas
    {
        public static void AddDias()
        {
            Console.Clear();
            Console.WriteLine("Adicionar Dias");
            Menu.Linha();

            var dataInicial = LerDataInicial();

            int diasParaAdd = Outros.LerInt("Digite a quantidade de dias para adicionar na data: ");

            DateTime dataNova = dataInicial.AddDays(diasParaAdd);

            ImprimirResultado(dataInicial, dataNova);
        }

        public static void AddSemanas()
        {
            Console.Clear();
            Console.WriteLine("Adicionar Semanas");
            Menu.Linha();

            var dataInicial = LerDataInicial();

            int semanasParaAdd = Outros.LerInt("Digite a quantidade de semanas para adicionar na data: ");

            DateTime dataNova = dataInicial.AddDays(semanasParaAdd * 7);

            ImprimirResultado(dataInicial, dataNova);
        }

        public static void AddMeses()
        {
            Console.Clear();
            Console.WriteLine("Adicionar Meses");
            Menu.Linha();

            var dataInicial = LerDataInicial();

            int mesesParaAdd = Outros.LerInt("Digite a quantidade de meses para adicionar na data: ");

            DateTime dataNova = dataInicial.AddMonths(mesesParaAdd);

            ImprimirResultado(dataInicial, dataNova);
        }

        public static void AddAnos()
        {
            Console.Clear();
            Console.WriteLine("Adicionar Anos");

            Menu.Linha();

            var dataInicial = LerDataInicial();

            int anosParaAdd = Outros.LerInt("Digite a quantidade de anos para adicionar na data: ");

            DateTime dataNova = dataInicial.AddYears(anosParaAdd);

            ImprimirResultado(dataInicial, dataNova);
        }

        public static DateTime LerDataInicial()
        {
            DateTime dataInicial;

            do
            {
                Console.Write($"Digite a data inicial (00/00/0000): ");
                if (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dataInicial))
                {
                    Menu.Erro("\nData inicial inválida! Tente novamente.\n");
                }

            } while (dataInicial == DateTime.MinValue);

            return dataInicial;
        }

        public static void ImprimirResultado(DateTime dataAntiga, DateTime dataNova)
        {
            Console.Clear();

            Console.WriteLine(); // Linha vazia

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Conversão feita com sucesso!");
            Console.ResetColor();

            Console.WriteLine(); // Linha vazia

            Thread.Sleep(800);

            Menu.Linha();

            Console.WriteLine(); // Linha vazia

            Console.WriteLine($"Data antiga: {dataAntiga.ToString("dd/MM/yyyy")}");
            Console.WriteLine(dataAntiga.ToString("D"));

            Console.WriteLine(); // Linha vazia
            Menu.Linha();
            Console.WriteLine(); // Linha vazia

            Console.WriteLine($"Data nova: {dataNova.ToString("dd/MM/yyyy")}");
            Console.WriteLine(dataNova.ToString("D"));
        }
    }
}