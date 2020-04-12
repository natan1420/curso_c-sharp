using System;
using System.Collections.Generic;
using System.Text;
using PastaFunções;

namespace PastaFunções
{
    class Iniciar
    {
        public static void Menu()
        {
            const int SAIR = 0;
            const int MEDIA = 1;
            const int MODA = 2;
            const int DESVIO_PADRAO = 3;
            const int FATORIAL = 4;

            int opçao = 1;


            while (opçao != SAIR)
            {
                Console.WriteLine("Escolha uma das opções:z\n" +
                    "   1 - Média\n" +
                    "   2 - Moda\n" +
                    "   3 - Desvio Padrão\n" +
                    "   4 - Calcular fatorial\n" +
                    "   0 - SAIR\n" +
                    "------------------------------------------");


                opçao = int.Parse(Console.ReadLine());

                if (opçao == MEDIA)
                    Matematica.Media();
                else if (opçao == MODA)
                    Matematica.Moda();
                else if (opçao == DESVIO_PADRAO)
                    Matematica.DesvioPadrao();
                else if (opçao == FATORIAL)
                    Matematica.Fatorial();
                else if (opçao == SAIR)
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Foi escolhido nenhuma das opções anteriores. Tente novamente:\n"+
                        "================================================");
                }
            }
        }

    }
}
