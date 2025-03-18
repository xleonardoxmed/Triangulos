namespace Triangulos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
          while(true)
            {
                Console.Clear();
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Classificador de Triângulos");
                Console.WriteLine("-------------------------------");
                int xside, yside, zside;
                while(true)
                {
                    Console.Write("Informe o valor do lado X: ");
                    bool converted = int.TryParse(Console.ReadLine(), out xside);          
                    if (converted)
                        break;
                }
                while (true)
                {
                    Console.Write("Informe o valor do lado Y: ");
                    bool converted = int.TryParse(Console.ReadLine(), out yside);                 
                    if (converted)
                        break;
                }
                while (true)
                {
                    Console.Write("Informe o valor do lado Z: ");
                    bool converted = int.TryParse(Console.ReadLine(), out zside);
                    if (converted)
                        break;
                }

                Console.WriteLine("Valores Informados\n");
                Console.WriteLine("Lado X: " + xside);
                Console.WriteLine("Lado Y: " + yside);
                Console.WriteLine("Lado Z: " + zside);

                bool validSides =
                    xside + yside > zside &&
                    yside + zside > xside &&
                    xside + zside > yside;

                string type = "";
                


                if (validSides == true)
                {
                    if (xside == yside && xside == zside && yside == zside)
                        type = "Equilátero";
                    else if (xside != yside && xside != zside && yside != zside)
                        type = "Escaleno";
                    else
                        type = "Isóceles";

                        Console.WriteLine($"Esse triângulo é válido e é: {type}");
                }
                else
                    Console.WriteLine(" \nERRO! \nEsses valores não respeitam a condição de existência! \n(A SOMA DE QUAISQUER DOIS LADOS NÃO PODE SER MENOR QUE O TERCEIRO VALOR)");

                Console.WriteLine("-------------------------------");
                Console.WriteLine("Deseja recomeçar?:  (S/N)");
                string ToContinue = Console.ReadLine()!.ToUpper();

                if (ToContinue != "S")
                    break;
            }
        }
        static bool TryToConvert(string text, out int result)
        {
            result = 0;
            if (text != "x")
            {
                result = 5;
                return true;
            }
            
            return false;
        }



    }
}
