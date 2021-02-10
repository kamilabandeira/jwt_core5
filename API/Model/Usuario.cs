using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Model
{
    public class Usuario
    {
        public Usuario()
        {
            Nome = "Andre";
            Idade = 23;
        }
        public string Nome { get; set; }
        public int Idade { get; set; }
    }
}
