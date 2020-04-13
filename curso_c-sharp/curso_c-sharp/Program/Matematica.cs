using System;
using System.Collections.Generic;
using System.Text;

namespace PastaFunções
{
    class Matematica
    {
        public static void Media()
        {
            Console.Clear();
            Console.WriteLine("\nFoi escolhido a opção Media"+
                "\n=======================================================");
                    

            Random aleatorio = new Random();

            //int x = aleatorio.Next(5, 10), y = aleatorio.Next(5, 10), z = aleatorio.Next(5, 10);

            double[] num = { aleatorio.Next(2,10) , aleatorio.Next(2, 10), aleatorio.Next(2, 10)};


            Console.WriteLine("Primeira nota: "+ num[0]);
            Console.WriteLine("Segunda nota: " + num[1]);
            Console.WriteLine("Terceira nota: " + num[2]);

            double soma = 0;

            for (int i = 0; i < num.Length; i++) soma += num[i];

            double media = Convert.ToDouble(soma) / num.Length;

            Console.WriteLine("\nA média das três notas é: {0}\n+" +
                "--------------------------------------------\n", Math.Round(media,2));

            if (media >= 8) Console.WriteLine("Parabéns ! Passou direto.\n");
            else if (media >= 6) Console.WriteLine("O aluno precisa fazer a prova final\n");
            else Console.WriteLine("O aluno está reprovado. =(\n");


            Console.WriteLine("\n=================== FUNÇÃO FINALIZADA COM SUCESSO ! =======================\n");
        }
        public static void Moda()
        {
            Console.Clear();
            Console.WriteLine("\nFoi escolhido a opção Moda" +
                "\n=======================================================");


            // A quantidade da lista de aleatórios é aleatória
            Random aleatorio_quantidade = new Random();
            int quantidade_aleatorio = aleatorio_quantidade.Next(6, 10);


            Random aleatorio_lista = new Random();
            List<int> lista_de_aleatorios = new List<int>();

            
            List<int> numeros_q_aparecem = new List<int>();


            //ADD números na lista de aleatórios
            // É cadastrado todos os números que aparecem na lista de aleatórios

            for (int i = 0; i < quantidade_aleatorio; i++)
            {
                lista_de_aleatorios.Add(aleatorio_lista.Next(5, 10));

                if(!(numeros_q_aparecem.Contains(lista_de_aleatorios[i])))
                {
                    numeros_q_aparecem.Add(lista_de_aleatorios[i]);
                }
            }


            
            List<int> aparecem_quantidades = new List<int>();

            int count = new int();



            // é contabilizado a quantidade de números que aparecem na lista numeros_q_aparecem
            for (int i = 0; i < numeros_q_aparecem.Count; i++)
            {
                count = 0;
                foreach (int x in lista_de_aleatorios)
                {
                    if (numeros_q_aparecem[i] == x) count++;                 
                }
                aparecem_quantidades.Add(count);
            }


            // Quantidade de vezes dos números que mais apareceram
            int qtde = 0;
            foreach (int x in aparecem_quantidades)
            {
                if (x > qtde) qtde = x;
            }


            List<int> endereços = new List<int>();


            // é cadastrado na lista endereços, o endereço dos números que mais apareceram na lista aparecem_quantidades
            for (int i =0; i< aparecem_quantidades.Count;i++)
            {
                if (aparecem_quantidades[i] == qtde) endereços.Add(i);
            }



            List<int> modas = new List<int>();
            //utilizando os endereços indicados na lista endereços, é pescado os valores que mais apareceram
            for (int i = 0; i < endereços.Count; i++)
            {
                modas.Add(numeros_q_aparecem[endereços[i]]);
            }


           
            Console.WriteLine("------- Lista de números escolhidos aleatoriamente: -----------");
            foreach (int x in lista_de_aleatorios)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("----------------------------------------------------------------");

            Console.WriteLine("------- Números da moda: -----------");
            foreach (int x in modas)
            {
                Console.WriteLine("A moda é {0}", x);
            }
            Console.WriteLine("\nAparecem {0} vezes", qtde);

            Console.WriteLine("\n=================== FUNÇÃO FINALIZADA COM SUCESSO ! =======================\n");
        }
    }
}
