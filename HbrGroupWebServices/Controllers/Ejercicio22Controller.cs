using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HbrGroupWebServices.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HbrGroupWebServices.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class Ejercicio22Controller : ControllerBase
    {
        public Dictionary<string,CEjercicio22> Get (string nombre1, int faltas1, string nombre2, int faltas2, string nombre3, int faltas3)
        {
            Dictionary<string, CEjercicio22> Empleados = new Dictionary<string, CEjercicio22>();

            CEjercicio22 Empeado1 = new CEjercicio22(nombre1, faltas1);
            CEjercicio22 Empeado2 = new CEjercicio22(nombre2, faltas2);
            CEjercicio22 Empeado3 = new CEjercicio22(nombre3, faltas3);

            Empleados.Add(Empeado1.NombreEmpleado,Empeado1);
            Empleados.Add(Empeado2.NombreEmpleado, Empeado2);
            Empleados.Add(Empeado3.NombreEmpleado, Empeado3);

            

            if (Empeado1.DiasFalta < Empeado2.DiasFalta && Empeado1.DiasFalta < Empeado3.DiasFalta)
            {
                Empleados.Add("El empleado que menos faltó", Empeado1);
            }
            if (Empeado2.DiasFalta < Empeado1.DiasFalta && Empeado2.DiasFalta < Empeado3.DiasFalta)
            {
                Empleados.Add("El empleado que menos faltó", Empeado2);
            }
            if (Empeado3.DiasFalta < Empeado1.DiasFalta && Empeado3.DiasFalta < Empeado2.DiasFalta)
            {
                Empleados.Add("El empleado que menos faltó", Empeado2);
            }

            return Empleados;
        }
    }
}
