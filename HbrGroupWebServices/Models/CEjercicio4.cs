using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HbrGroupWebServices.Models
{
    public class CEjercicio4
    {
        /*4) Crear un programa que pida al usuario dos números reales. Si el segundo no es cero, mostrará el
             resultado de dividir entre el primero y el segundo. Por el contrario, si el segundo número es cero,
             escribirá “Error: No se puede dividir entre cero”. */
        public string Resultado{ get; set; }

        public string Calcular(double a, double b)
        {
            string result;

            if (b == 0)
            {
                result = "No se puede multiplicar por cero";
            }
            else
            {
                double Div = a / b;

                result = Div.ToString();
            }

            return result;
        }

    }
}
