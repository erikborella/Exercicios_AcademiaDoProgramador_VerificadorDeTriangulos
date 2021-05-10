using System;
using System.Collections.Generic;
using System.Text;

namespace Triangulos
{
    class Ajudadores
    {
        public static double LerDouble()
        {
            while (true)
            {
                try
                {
                    double n = Convert.ToDouble(Console.ReadLine());
                    return n;
                }
                catch (Exception)
                {
                    ImprimirErro("Digite um numero!");
                }
            }
        }

        private static void ImprimirErro(string mensagem)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(mensagem);
            Console.ResetColor();
        }
    }
}
