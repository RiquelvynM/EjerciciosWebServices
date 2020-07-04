using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HbrGroupWebServices.Models
{
    /* 2) Crear un programa que pida al usuario dos números enteros y diga si el primero es múltiplo del
     segundo (pista: igual que antes, habrá que ver si el resto de la división es cero: a % b == 0). */

    public class CEjercicio2
    {
        public string Resultado { get; set; }
        public string Calcular(int a, int b)
        {
            string result;
            int modulo = a % b;

            if (modulo == 0)
            {
                result = a.ToString() + " Es multiplo de " + b.ToString(); 
            }
            else
            {
                result = a.ToString() + " No es multiplo de " + b.ToString();
            }

            return result;
        }
        
    }
}
