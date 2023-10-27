using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUnidad2ASA
{
    public class Ejercicio
    {

        public void MatrizDesordenada(int[] numeros)
        {
            Random random = new Random();
            numeros = new int[100];


            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = random.Next(1, 100);
                Console.WriteLine($"Matriz desordenada:{numeros}");

            }
        }

        public void ImprimirMatriz(int[] matriz)
        {

            foreach (var numero in matriz)
            {
                Console.Write(numero + "");
            }
            Console.WriteLine();
        }

        public void OrdenarDescendente(int[] matriz)
        {
            for (int i = 0; i < matriz.Length - 1; i++)
            {
                int maximo = i;
                for (int j = i + 1; j < matriz.Length; j++)
                {
                    if (matriz[j] > matriz[maximo])
                    {
                        maximo = j;
                    }
                }
                int temp = matriz[i];
                matriz[i] = matriz[maximo];
                matriz[maximo] = temp;
            }
        }

        public int BusquedaBinaria(int[] matriz, int objetivo)
        {
            int izquierda = 0;
            int derecha = matriz.Length - 1;

            while (izquierda <= derecha)
            {
                int medio = izquierda + (derecha - izquierda) / 2;

                if (matriz[medio] == objetivo)
                {
                    return medio;

                }

                if (matriz[medio] > objetivo)
                {
                    izquierda = medio - 1;
                }
                else
                {
                    derecha = medio + 1;
                }
            }

            return -1;
        }

    }
}
