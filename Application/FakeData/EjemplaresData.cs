using Application.Entities;
using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.FakeData
{
    public class EjemplaresData : IEjemplaresData
    {
        private List<Ejemplar> ejemplares;
        public const string PRESTADO = "Prestado";
        public const string DISPONIBLE = "Disponible";

        public EjemplaresData()
        {
            this.ejemplares = new List<Ejemplar>() {
                new Ejemplar()
                {
                    Id = 1,
                    Codigo = "AAA",
                    LibroId = 1,       
                    Estado = DISPONIBLE
                },
                new Ejemplar()
                {
                    Id = 2,
                    Codigo = "BBB",
                    LibroId = 1,
                    Estado = DISPONIBLE
                },
                new Ejemplar()
                {
                    Id = 3,
                    Codigo = "AAA",
                    LibroId = 2,
                    Estado = DISPONIBLE
                },
                new Ejemplar()
                {
                    Id = 4,
                    Codigo = "BBB",
                    LibroId = 2,
                    Estado = DISPONIBLE
                },
                new Ejemplar()
                {
                    Id = 5,
                    Codigo = "AAA",
                    LibroId = 3,
                    Estado = DISPONIBLE
                },
                new Ejemplar()
                {
                    Id = 6,
                    Codigo = "BBB",
                    LibroId = 3,
                    Estado = DISPONIBLE
                }
            };
        }

        public Ejemplar ObtenerEjemplarDisponible(int libroId)
        {
            Ejemplar ejemplar = null;
            try
            {
                List<Ejemplar> ejemplaresDisponibles = this.ejemplares.FindAll(e => e.LibroId == libroId && e.Estado == DISPONIBLE);

                if(ejemplaresDisponibles.Count <= 0)
                    throw new Exception("No existen ejemplares disponibles del libro");

                ejemplar = ejemplaresDisponibles[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ejemplar;
        }

        public void PrestarEjemplar(int idEjemplar)
        {
            try
            {
                Ejemplar ejemplar = this.ejemplares.Find(e => e.Id == idEjemplar);
                int indexEjemplar = this.ejemplares.FindIndex(e => e.Id == idEjemplar);

                ejemplar.Estado = PRESTADO;
                this.ejemplares[indexEjemplar] = ejemplar;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
