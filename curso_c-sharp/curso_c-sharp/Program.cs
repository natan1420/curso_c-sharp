using System;

namespace curso_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // AULA 2 - TIPOS DE VARIÁVEIS E CONVERSÕES TESTE

            //Declaração de variáveis e formas de declarar
            long i = 123;
            double d = 1111.111;


            var a = "Olá";
            double g = 0;

            //Mannipulação dos resultados
            Console.WriteLine(i);
            Console.WriteLine(Math.Round(d, 2));
            Console.WriteLine(i + d);
            Console.WriteLine(g);
            Console.WriteLine(a);

            //conversão de variáveis
            t = Convert.ToString(d);
        }
    }
}
