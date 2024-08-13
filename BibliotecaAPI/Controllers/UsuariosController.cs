using Application.DTO;
using Application.Entities;
using Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaAPI.Controllers
{
    [Route("api/usuarios")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private IUsuariosManager usuariosManager;
        public UsuariosController(IUsuariosManager usuariosManager)
        {
            this.usuariosManager = usuariosManager;
        }

        [HttpGet]
        [Route("listarUsuarios")]
        public IActionResult ListarUsuarios()
        {
            try
            {
                List<Usuario> usuarios = usuariosManager.GetUsuarios();
                return Ok(usuarios);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }
    }
}
