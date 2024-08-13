using Application.Entities;
using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.FakeData
{
    public class LibrosData : ILibrosData
    {
        private List<Libro> libros;

        public LibrosData() {
            this.libros = new List<Libro>() {
                new Libro()
                {
                    Id = 1,
                    Titulo = "Cien años de soledad",
                    Anio = "1967",
                    ISBN ="978-950-563-656-3"
                },
                new Libro()
                {
                    Id = 2,
                    Titulo = "Crónica de una muerte anunciada",
                    Anio = "1981",
                    ISBN ="978-950-563-656-3"
                },
                new Libro()
                {
                    Id = 3,
                    Titulo = "El amor en los tiempos del cólera",
                    Anio = "1985",
                    ISBN ="978-950-563-656-3"
                }
            };
        }

        public List<Libro> GetLibros()
        {
            return this.libros;
        }

        
    }
}
