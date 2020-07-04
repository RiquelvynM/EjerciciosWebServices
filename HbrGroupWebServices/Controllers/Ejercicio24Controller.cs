﻿using System;
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
    public class Ejercicio24Controller : ControllerBase
    {
        public List<int> Get(int filas, int columnas)
        {
            CEjercicio24 Procesar = new CEjercicio24();

            return Procesar.Insertar(filas, columnas);
        }
    }
}
