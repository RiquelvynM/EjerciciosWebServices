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
    public class Ejercicio10Controller : ControllerBase
    {
        public List<int> Get()
        {
            CEjercicio10 Procesar = new CEjercicio10();


            return Procesar.Calcular();
        }

    }
}
