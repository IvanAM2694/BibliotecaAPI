﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Entities
{
    public class Libro
    {
        public int Id { get; set; }
        public string Titulo {  get; set; }
        public string Anio { get; set; }
        public string ISBN { get; set; }
        public int AutorId { get; set; }
    }
}
