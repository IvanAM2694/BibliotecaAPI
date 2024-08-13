using Application.DTO;
using Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaAPI.Controllers
{
    [Route("api/prestamos")]
    [ApiController]
    public class PrestamosController : ControllerBase
    {
        private IPrestamosManager prestamosManager;
        public PrestamosController(IPrestamosManager prestamosManager)
        {
            this.prestamosManager = prestamosManager;
        }

        [HttpPost]
        [Route("registrarPrestamo")]
        public IActionResult RegistrarPrestamo(RegistroPrestamo registroPrestamo)
        {
            try
            {
                prestamosManager.RegistrarPrestamo(registroPrestamo);
                return Ok("Se registro prestamo de manera exitosa");
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }
    }
}
