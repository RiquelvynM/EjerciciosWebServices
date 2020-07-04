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
    public class Ejercicio20Controller : ControllerBase
    {
        public Dictionary<string,CEjercicio20> Get(string pais1, int tempMen1P1, int tempMen2P1, int tempMen3P1, string pais2, int tempMen1P2, int tempMen2P2,
            int tempMen3P2, string pais3, int tempMen1P3, int tempMen2P3, int tempMen3P3, string pais4, int tempMen1P4, int tempMen2P4,
            int tempMen3P4)
        {
            Dictionary<string, CEjercicio20> Grupo = new Dictionary<string, CEjercicio20>();

            CEjercicio20 Proceso1 = new CEjercicio20(pais1, tempMen1P1, tempMen2P1, tempMen3P1);
            CEjercicio20 Proceso2 = new CEjercicio20(pais2, tempMen1P2, tempMen2P2, tempMen3P2);
            CEjercicio20 Proceso3 = new CEjercicio20(pais3, tempMen1P3, tempMen2P3, tempMen3P3);
            CEjercicio20 Proceso4 = new CEjercicio20(pais4, tempMen1P4, tempMen2P4, tempMen3P4);

            Grupo.Add(Proceso1.Pais, Proceso1);
            Grupo.Add(Proceso2.Pais, Proceso2);
            Grupo.Add(Proceso3.Pais, Proceso3);
            Grupo.Add(Proceso4.Pais, Proceso4);

            return Grupo;
        }
    }
}
