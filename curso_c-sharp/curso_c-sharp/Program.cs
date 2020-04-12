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


            //Iniciar.Menu();            

            float x;

            int i = 6, j = 6;


            float[,] matriz = new float[i, j];
            x = matriz[0, 0]= 26;


            int novo_i = 2, novo_j = 2;

            ResizeArray(ref matriz, novo_i, novo_j);

            

        }

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






    }
}
