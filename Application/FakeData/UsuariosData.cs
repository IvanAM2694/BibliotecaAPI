using Application.Entities;
using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.FakeData
{
    public class UsuariosData : IUsuariosData
    {
        private List<Usuario> usuarios;

        public UsuariosData() { 
            this.usuarios = new List<Usuario>()
            {
                new Usuario()
                {
                   Id = 1,
                   Nombres = "Iván Hernán",
                   Apellidos = "Aguilar Mariños",
                   Direccion = "Marcabalito",
                   DNI = "70010307",
                   Email = "ivan.am2694@gmail.com",
                   Telefono = "980147491",

                }
            };
        }
    }
}
