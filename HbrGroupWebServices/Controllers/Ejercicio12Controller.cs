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
    public class Ejercicio12Controller : ControllerBase
    {
        public List<int> Get()
        {
            CEjercicio12 Procesar = new CEjercicio12();


            return Procesar.Calcular();
        }
    }
}
