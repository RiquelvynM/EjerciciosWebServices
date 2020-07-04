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
    public class Ejercicio6Controller : ControllerBase
    {
        public CEjercicio6 Get(int a, int b)
        {
            CEjercicio6 Procesar = new CEjercicio6();

            Procesar = new CEjercicio6 { Resultado = Procesar.Calcular(a, b) };

            return Procesar;
        }
    }
}
