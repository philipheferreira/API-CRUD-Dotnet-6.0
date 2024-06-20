using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaDeTarefas.Repositorios.Interfaces;

namespace SistemaDeTarefas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase{

        private readonly IUsuarioRepositorio _usuarioRepositorio;

        [HttpGet]
        public ActionResult<List<Models.UsuarioModel>> BuscarTodosUsuarios(){
            return Ok();
        }
    }
}
