using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai_inlock_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_inlock_webAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class JogosController : ControllerBase
    {
        private IJogoRepository _jogoRepository { get; set; }
        public JogosController()
        {

        }
    }
}
