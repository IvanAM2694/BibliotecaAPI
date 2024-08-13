using Application.Entities;
using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.FakeData
{
    public class PrestamosData : IPrestamosData
    {
        private List<Prestamo> prestamos;

        public PrestamosData() {
            this.prestamos = new List<Prestamo>();
        }

        public Prestamo RegistrarPrestamo(Prestamo prestamo) {
            try
            {
                prestamo.Id = GetSiguienteId();
                AddPrestamo(prestamo);
                
            }
            catch (Exception ex)
            {
                throw new Exception("Fallo al registrar el prestamo");
            }

            return prestamo;
        }

        private int GetSiguienteId()
        {
            int id = 0;
            id = this.prestamos.Count + 1;

            return id;
        }

        private void AddPrestamo(Prestamo prestamo)
        {
            this.prestamos.Add(prestamo);
        }
    }
}
