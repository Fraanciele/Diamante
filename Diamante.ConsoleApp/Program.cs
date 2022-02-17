using System;

namespace Diamante.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variaveis 

            int tamanhoDoDiamante;

            //Verficar se é impar

            do
            {
                Console.WriteLine("Digite um Numero impar: ");
                tamanhoDoDiamante = System.Convert.ToInt32(Console.ReadLine());
                if (tamanhoDoDiamante % 2 == 0)
                    Console.WriteLine("Número Invalido, Tente novamente: ");
            }
            while (tamanhoDoDiamante % 2 == 0);



            int espacos = ((tamanhoDoDiamante - 1) / 2);
            int X = 1;

            for (int linha_i = 0; linha_i < ((tamanhoDoDiamante - 1) / 2); linha_i++)
            {
                for (int linha_j = 0; linha_j < espacos; linha_j++)
                {
                    Console.Write(" ");
                }
                for (int linha_j = 0; linha_j < X; linha_j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
                espacos--;
                X += 2;
            }
            for (int linha_i = 0; linha_i < tamanhoDoDiamante; linha_i++)
            {
                Console.Write("X");
            }
            Console.WriteLine();

            espacos++;

            X -= 2;
            for (int linha_i = 0; linha_i < ((tamanhoDoDiamante - 1) / 2); linha_i++)
            {
                for (int linha_j = 0; linha_j < espacos; linha_j++)
                {
                    Console.Write(" ");
                }
                for (int linha_j = 0; linha_j < X; linha_j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
                espacos++;
                X -= 2;
            }

            Console.ReadLine();
        }
    }
}