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
    public class Ejercicio7Controller : ControllerBase
    {
        public CEjercicio7 Get(int a)
        {
            CEjercicio7 Proceso = new CEjercicio7();

            Proceso = new CEjercicio7 { Resultado = Proceso.Calcular(a) };


            return Proceso;
        }
    }
}
