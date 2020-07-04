using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HbrGroupWebServices.Models
{
    /*19) Crear una matriz de 2 filas y 5 columnas. Realizar la carga de componentes por columna (es decir
          primero ingresar toda la primer columna, luego la segunda columna y así sucesivamente)
          Imprimir luego la matriz */
    public class CEjercicio19
    {
        public List<int> Calcular(int a, int b, int c, int d, int e, int f, int g, int h, int i, int j)
        {
            List<int> resultados = new List<int>();
            int[,] numeros = new int[2, 5];


            numeros[0, 0] = a;
            numeros[0, 1] = b;
            numeros[0, 2] = c;
            numeros[0, 3] = d;
            numeros[0, 4] = e;

            numeros[1, 0] = f;
            numeros[1, 1] = g;
            numeros[1, 2] = h;
            numeros[1, 3] = i;
            numeros[1, 4] = j;

            for (int fila = 0; fila < 2; fila++)
            {
                for (int colum= 0; colum < 5; colum++)
                {
                    resultados.Add(numeros[fila, colum]);
                }
            }


            return resultados;




        }
    }
}
