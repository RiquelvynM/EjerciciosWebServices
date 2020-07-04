    using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace HbrGroupWebServices.Models
{
    /*23) Crear una matriz de n * m filas (cargar n y m por teclado) Intercambiar la primer fila con la segundo.
          Imprimir luego la matriz. */
    public class CEjercicio23
    {
        public List<int> Insertar(int Filas, int columnas)
        {
            List<int> resultado = new List<int>();

            int[,] matriz;

            Random Numeros = new Random();

            matriz = new int[Filas, columnas];

            for (int f = 0; f < Filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    matriz[f, c] = Numeros.Next(0,20);
                    resultado.Add(matriz[f, c]);
                }
            }



            return resultado;
        }
    }
}
