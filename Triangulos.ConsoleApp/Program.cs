using System;
using System.Xml.Schema;

namespace Triangulos.ConsoleApp
{
    class TrianguleClassificator
    {
       public static bool validTriangule(int xside, int yside, int zside)
        {
            bool validSides =
                   xside + yside > zside &&
                   yside + zside > xside &&
                   xside + zside > yside;

            return validSides;
        }

       public static string classificate(int xside, int yside, int zside)
        {
            string type = "Não classificado";

            if (xside == yside && xside == zside && yside == zside)
                type = "Equilátero";
            else if (xside != yside && xside != zside && yside != zside)
                type = "Escaleno";
            else
                type = "Isóceles";

            return type;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
          while(true)
            {
                showMenu();
                int xside = readSides(" X");
                int yside = readSides(" Y");
                int zside = readSides(" Z");
                showValuesInformed(xside,yside,zside);

                bool itsValid =
                TrianguleClassificator.validTriangule(xside, yside, zside);

                if (itsValid)
                {
                    string type = TrianguleClassificator.classificate(xside, yside, zside);
                    Console.WriteLine($"O triângulo é {type}");
                }
                else
                    Console.WriteLine("Erro! Os valores informados não formam um triângulo válido!");

                Console.WriteLine("-------------------------------");
                Console.WriteLine("Deseja recomeçar?:  (S/N)");
                string ToContinue = Console.ReadLine()!.ToUpper();

                if (ToContinue != "S")
                    break;
            }
        }

        static void showMenu()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Classificador de Triângulos");
            Console.WriteLine("-------------------------------");
        }

        static int readSides(string sideName)
        {
            int value;

            while (true)
            {
                Console.Write($"Informe o valor do lado{sideName}: ");
                bool converted = int.TryParse(Console.ReadLine(), out value);
                if (converted)
                    break;
            }
            return value;
        }
        static void showValuesInformed(int xside, int yside,int zside)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Valores Informados");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Lado X: " + xside);
            Console.WriteLine("Lado Y: " + yside);
            Console.WriteLine("Lado Z: " + zside);
            Console.WriteLine("-------------------------------");

        }
       
       
    }
}
