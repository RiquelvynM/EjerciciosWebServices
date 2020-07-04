using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using HbrGroupWebServices.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HbrGroupWebServices.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class Ejercicio8Controller : ControllerBase
    {

        public List<int> Get()
        {
            CEjercicio8 Procesar = new CEjercicio8();

            return Procesar.Calcular();
        }

    }
}
