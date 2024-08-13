using Application.Entities;
using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Negocio
{
    public class UsuariosManager : IUsuariosManager
    {
        private IUsuariosData usuariosData;
        public UsuariosManager(IUsuariosData usuariosData)
        {
            this.usuariosData = usuariosData;
        }
        public List<Usuario> GetUsuarios()
        {
            return usuariosData.GetUsuarios();
        }
    }
}
