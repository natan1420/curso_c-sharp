using System;
using PastaFunções;
using System.Windows;

namespace curso_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {

            // AULA 10- PROGRAMAÇÃO ORIENTADA A FUNÇÕES


            Iniciar.Menu();

            //NA AULA 10 FOI ESTUDADO PROGRAMAÇÃO ESTRUTURADA A FUNÇÕES E DESENVOLVIDO OS CONCEITOS NECESSÁRIOS
            // PARA TRABALHAR E MANIPULAR MATRIZES




            //-----------------------------------------------------------------------------------------------------------------------------------------------

            /*   REDIMENSIONANDO MATRIZ (ACHEI NA INTERNET) O CÓDIGO NÃO FUNCIONA QUANDO A MATRIZ DIMINUI

            /// <summary>
            /// Mthod for resizing a multi dimensional array
            /// </summary>
            /// <param name="original">Original array you want to resize
            /// <param name="cols"># of columns in the new array
            /// <param name="rows"># of rows in the new array
            public static void ResizeArray(ref float[,] original, int cols, int rows)
            {
                //create a new 2 dimensional array with
                //the size we want
                float[,] newArray = new float[rows, cols];
                //copy the contents of the old array to the new one
                Array.Copy(original, newArray, original.Length);
                //set the original to the new array
                original = newArray;
            }           
            */

            /*============== REDIMENSIONANDO MATRIZ ================
             * 
                SOLUÇÃO 1 (MELHOR OPÇÃO, SOLUÇÃO MAIS SIMPLES)
                - GUARDAR AS VARIÁVEIS DA MATRIZ EM UM ARRAY[] OU UMA LIST ---> EM FORMA DE CSV
                AS OPERAÇÕES NECESSÁRIAS SERIAM CHAMADAS POR FUNÇÃO E DENTRO DA FUNÇÃO SERIA REALIZADO O SPLIT DA MESMA PARA REALIZAR AS OPERAÇÕES NECESSÁRIAS
                E RETORNARIA COM O NOVO TAMANHO DO ARRAY[] OU LIST


                SOLUÇÃO 2 (GAMBIARRA POR USAR UM ELEMENTO DO FORM'S)
              - GUARDAR AS VARIÁVEIS DA MATRIZ EM UM OBJETO, DATA_GRID_VIEW OU SEMELHANTE

              
                SOLUÇÃO 3
                - GUARDAR AS VARIÁVEIS DA MATRIZ EM UM ARRAY[] OU UMA LIST ---> EM FORMA DE OBJETO, CADA ATRIBUTO DO OBJETO SERIA UMA COLUNA

                SOLUÇÃO 4
                - GUARDAR AS VARIÁVEIS DA MATRIZ EM UM ARRAY[] OU UMA LIST ---> EM FORMA DE OBJETO,
                COM UM ATRIBUTO E ESSE ATRIBUTO SERIA UM LIST, O QUE PRESENTARIA AS COLUNAS DA MATRIZ
                LINHA DA MATRIZ = A POSIÇÃO DO ARRAY[] OU LIST
                COLUNA DA MATRIZ = A POSIÇÃO DO ARRAY[] OU LIST DENTRO DO OBJETO

            */

        }
    }
}
