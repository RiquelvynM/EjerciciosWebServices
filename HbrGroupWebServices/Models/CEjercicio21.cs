using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HbrGroupWebServices.Models
{
    /*21) Confeccionar una clase para administrar una matriz irregular de 5 filas y 1 columna la primer fila, 2
          columnas la segunda fila y así sucesivamente hasta 5 columnas la última fila (crearla sin la intervención
          del operador)
          Realizar la carga por teclado e imprimir posteriormente. */
    public class CEjercicio21
    {
        public int[][] Procesar (int num1, int num2, int num3, int num4, int num5,int num6, int num7, int num8, int num9, int num10,
            int num11, int num12, int num13, int num14, int num15)
        {
            

            int[][] vector = new int[5][];

            vector[0] = new int[1];
            vector[1] = new int[2];
            vector[2] = new int[3];
            vector[3] = new int[4];
            vector[4] = new int[5];

            vector[0][0] = num1;

            vector[1][0] = num2;
            vector[1][1] = num3;

            vector[2][0] = num4;
            vector[2][1] = num5;
            vector[2][2] = num6;

            vector[3][0] = num7;
            vector[3][1] = num8;
            vector[3][2] = num9;
            vector[3][3] = num10;

            vector[4][0] = num11;
            vector[4][1] = num12;
            vector[4][2] = num13;
            vector[4][3] = num14;
            vector[4][4] = num15;



            return vector;

        }
    }
}
