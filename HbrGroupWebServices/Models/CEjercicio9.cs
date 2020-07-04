using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HbrGroupWebServices.Models
{
    /*9) Crea un programa que escriba en pantalla los números pares del 26 al 10 (descendiendo), usando
         "while". */
    public class CEjercicio9
    {
        //Asegurate de borrar este metodo de los otros ejercicios
        //public List<int> Resultado{ get; set; }
        public List<int> Calcular()
        {
            int num1 = 28;
            int num2 = 10;

            List<int> resultados = new List<int>();

            //creamos bucle donde el primer numero no reste menos de 10, el limite es 10
            while (num1 > num2)
            {
                num1 -= 2;

                resultados.Add(num1);
            }

            return resultados;
        }
    }
}
