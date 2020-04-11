using System;

namespace curso_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // AULA 3 - OPERADORES LÓGICOS E CONDICIONAIS

            //Declaração de variáveis

            Random xxx = new Random();
            int i = xxx.Next();

            //double d = 1111.111;


            //var a = "Olá";
            //double g = 0;


            Console.WriteLine("\n----------------------- FUNÇÃO IF/ELSE e SWITCH -----------------------------\n");


            // IF

            Console.WriteLine("if-1");

            if (i > 0)
            {
                Console.WriteLine(i + " é número positivo\n");
            }
            Console.WriteLine("if-2");
            if (i>0)
                Console.WriteLine(i + " é número positivo\n");

            Console.WriteLine("if-3");
            if (i > 0) Console.WriteLine(i + " é número positivo\n");



            Console.WriteLine("\n-----------------------");
            // Ternário
            Console.WriteLine("ternário");
            Console.WriteLine(i > 0 ? i + " é número positivo": i + "é número negativo\n");


            Console.WriteLine("\n-----------------------");

            //if + else
            Console.WriteLine("if + else - 1");
            if (i % 2 > 0 )
                Console.WriteLine(i + " é número ímpar\n");
            else
                Console.WriteLine(i + " é número par\n");



            Console.WriteLine("if + else - 2");
            if (i % 2 > 0)
            {
                Console.WriteLine(i + " é número ímpar\n");
            }
            else
            {
                Console.WriteLine(i + " é número par\n");
            }

            Console.WriteLine("if + else - 3");
            if (i % 2 > 0)
            {
                Console.WriteLine(i + " é número ímpar\n");
            }
            else if (i==0)
            {
                Console.WriteLine(i + " é ZERO\n");
            }
            else
            {
                Console.WriteLine(i + " é número par\n");
            }



            Console.WriteLine("\n-----------------------");

            //Switch

            Random aleatorio = new Random();
            int t = aleatorio.Next(1, 4);
            

            switch (t)
            {
                case 1:
                    {
                        Console.WriteLine("O número aleatório é " + t );
                        Console.WriteLine(":)\n");
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("O número aleatório é " + t );
                        Console.WriteLine(":)\n");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("O número aleatório é " + t );
                        Console.WriteLine(":)\n");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("O número aleatório é " + t);
                        Console.WriteLine(":)\n");
                        break;
                    }
            }

            Console.WriteLine("\n\n");
            Console.WriteLine("\n----------------------- LOOP -----------------------------\n");


            /*
             Loop:
             - While
             - Do While
             - for
             - for each
             - Funções Recursivas
              
             */

            // Loop - While
            Console.WriteLine("\n----------------------- While\n");

            int j = 5;

            while(j>=0)
            {
                Console.WriteLine(j);
                j--;
            }


            // Loop - While
            Console.WriteLine("\n----------------------- Função Recursiva\n");

            Console.WriteLine("\n\nTabuada:");



            Tabuada(20);

            
        }


        /// <summary>
        /// Essa é a descrição dessa bodega
        /// </summary>
        /// <param name="x">Número da taboada</param>
        /// <param name="y">A tabuada vai até o número 10 por padrão</param>
        /// <returns></returns>
        /// 

        public static void Tabuada (int x, int y=0)
        {
            Console.WriteLine(x + " x " + y + " = " + x*y);

            if (y == 10) return;

            Tabuada(x, y + 1);

        }




    }
}
