using Application.DTO;
using Application.Entities;
using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Negocio
{
    public class PrestamosManager : IPrestamosManager
    {
        private IEjemplaresData ejemplaresData;
        private IPrestamosData prestamosData;
        public PrestamosManager(IEjemplaresData ejemplaresData, IPrestamosData prestamosData) { 
            this.ejemplaresData = ejemplaresData;
            this.prestamosData = prestamosData;
        }

        public Prestamo RegistrarPrestamo(RegistroPrestamo registroPrestamo)
        {
            Prestamo prestamo = null;
            try
            {
                Ejemplar ejemplar = this.ejemplaresData.ObtenerEjemplarDisponible(registroPrestamo.IdLibro);
                prestamo = new Prestamo()
                {
                    CodigoEjemplar = ejemplar.Codigo,
                    FechaPrestamo = DateTime.Now,
                    IdUsuario = registroPrestamo.IdUsuario
                };

                prestamo = this.prestamosData.RegistrarPrestamo(prestamo);

                this.ejemplaresData.PrestarEjemplar(ejemplar.Id);

            }
            catch (Exception ex){
                throw ex;
            }

            return prestamo;
        }
    }
}
