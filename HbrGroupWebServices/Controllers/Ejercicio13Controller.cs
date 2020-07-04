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
    public class Ejercicio13Controller : ControllerBase
    {
        public List<int> Get()
        {
            CEjercicio13 Procesar = new CEjercicio13();

            return Procesar.Calcular();
        }
    }
}
