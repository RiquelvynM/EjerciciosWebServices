using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HbrGroupWebServices.Models
{
    /*1) El usuario tecleará dos números (x e y), y el programa deberá calcular cual es el resultado de su
división y el resto de esa división.*/
    public class CEjercicio1
    {
        //Se crearon dos propiedades para almacenar el resultado de los metodos CalcularDiv y CalcularMod
        public int Division { get; set; }
        public int Modulo { get; set; }

        public int CalcularDiv(int Num1, int Num2)
        {
            int result = Num1 / Num2;

            return result;
        }

        public int CalcularMod(int num1, int num2)
        {
            int result = num1 % num2;

            return result;
        }

    }
}
