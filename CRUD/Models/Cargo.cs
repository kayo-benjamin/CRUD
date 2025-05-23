using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Models
{
    public class Cargo
    {
        public int Id { get; set; }
        public string TipoNome { get; set; }

        public Cargo() { }

        public Cargo(int id, string tipoNome)
        {
            Id = id;
            TipoNome = tipoNome;
        }
    }
}
