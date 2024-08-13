using Application.DTO;
using Application.Entities;
using Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaAPI.Controllers
{
    [Route("api/libros")]
    [ApiController]
    public class LibrosController : ControllerBase
    {
        private ILibrosManager librosManager;
        public LibrosController(ILibrosManager librosManager)
        {
            this.librosManager = librosManager;
        }

        [HttpGet]
        [Route("listarLibros")]
        public IActionResult ListarLibros()
        {
            try
            {
                List<Libro> libros = librosManager.GetLibros();
                return Ok(libros);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }
    }
}
