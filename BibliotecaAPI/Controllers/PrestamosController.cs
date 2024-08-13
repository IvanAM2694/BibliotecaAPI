using Application.DTO;
using Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;

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

                dynamic response = new ExpandoObject();
                response.message = "Se registro correctamente el prestamo";


                return Ok(response);
            }
            catch (Exception ex)
            {
                dynamic response = new ExpandoObject();
                response.message = ex.Message; 

                return Ok(response);
            }
        }
    }
}
