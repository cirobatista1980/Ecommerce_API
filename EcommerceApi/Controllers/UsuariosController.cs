using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceApi.Core.Entities;
using EcommerceApi.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EcommerceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioService service;
        private readonly ILogger logger;
        public UsuariosController(IUsuarioService _service, ILogger<UsuariosController> _logger)
        {
            service = _service;
            logger = _logger;
        }
        [HttpPost]
        public ActionResult Post([FromBody] Usuario usuario)
        {
            try
            {
                var retorno = service.Login(usuario);
                return Ok(retorno);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "UsuariosController.Post", usuario);
                return new StatusCodeResult(500);
            }
        }
    }
}