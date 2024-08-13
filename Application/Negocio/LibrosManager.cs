using Application.Entities;
using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Negocio
{
    public class LibrosManager : ILibrosManager
    {
        private ILibrosData librosData;
        public LibrosManager(ILibrosData librosData) { 
            this.librosData = librosData;
        }
        public List<Libro> GetLibros()
        {
            return librosData.GetLibros();
        }
    }
}
