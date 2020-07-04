using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HbrGroupWebServices.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace HbrGroupWebServices.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class Ejercicio2Controller : ControllerBase
    {

        public CEjercicio2 Get(int a, int b)
        {
            CEjercicio2 Procesar = new CEjercicio2();

            Procesar = new CEjercicio2 { Resultado = Procesar.Calcular(a, b) };



            return Procesar;
        }

    }
}
