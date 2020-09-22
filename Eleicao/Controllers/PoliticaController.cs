using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eleicao.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eleicao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PoliticaController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok("Lista dos candidatos");
        }

        [HttpPost]
        public async Task<IActionResult> Post(Politica politica)
        {
            return Ok("Candidato criado com sucesso!!!");
        }
    }
}
