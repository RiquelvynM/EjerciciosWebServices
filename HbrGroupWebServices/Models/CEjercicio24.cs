using Microsoft.Extensions.Hosting.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;

namespace HbrGroupWebServices.Models
{
    /*24) Crear una matriz de n * m filas (cargar n y m por teclado) Imprimir los cuatro valores que se
          encuentran en los vértices de la misma (mat[0][0] etc.) */
    public class CEjercicio24
    {
        public List<int> Insertar (int filas, int columnas)
        {
            List<int> Resultados = new List<int>();
            int[][] matriz;

            Random numeros = new Random();

            matriz = new int[filas][];

            for (int i = 0; i < columnas; i++)
            {
                matriz[filas] = new int[columnas];

                for (int c = 0; c < columnas; c++)
                {
                    matriz[filas][columnas] = numeros.Next(0, 20);
                    Resultados.Add(matriz[filas][columnas]);
                }
            }

            return Resultados;
            
        }
    }
}
