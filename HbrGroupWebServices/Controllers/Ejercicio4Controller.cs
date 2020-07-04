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
    public class Ejercicio4Controller : ControllerBase
    {
        public CEjercicio4 Get(double a, double b)
        {
            CEjercicio4 Procesar = new CEjercicio4();

            Procesar = new CEjercicio4 { Resultado = Procesar.Calcular(a, b) };

            return Procesar;
        }
    }
}
