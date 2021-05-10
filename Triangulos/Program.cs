using System;

using Triangulos.FormasGeometricas;

namespace Triangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                double x, y, z;

                x = LerValorDoTriangulo("X");
                y = LerValorDoTriangulo("Y");
                z = LerValorDoTriangulo("Z");

                Triangulo triangulo = new Triangulo(x, y, z);

                Console.WriteLine($"O Triangulo é: {triangulo.Tipo}");

                Console.WriteLine();
                Console.Write("Digite S para sair ou qualquer coisa para executar novamente: ");

                string opcao = Console.ReadLine();

                if (opcao.Equals("S", StringComparison.OrdinalIgnoreCase))
                    break;
            }
        }

        private static double LerValorDoTriangulo(string nomeDoValor)
        {
            Console.Write($"Digite o numero de {nomeDoValor}: ");
            return Ajudadores.LerDouble();
        }
    }
}
