using Application.DTO;
using Application.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IPrestamosManager
    {
        Prestamo RegistrarPrestamo(RegistroPrestamo registroPrestamo);
    }
}
