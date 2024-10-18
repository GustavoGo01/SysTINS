using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTINSClass
{
    public class Nivel
    {
        public int Id {  get; set; }
        public string? Nome { get; set; }
        public string? sigla {  get; set; }

        public Nivel() { } // método construtor (new)

        public Nivel(string? nome, string? sigla)
        {
            Nome = nome;
            sigla = sigla;
        }
        public Nivel(int id, string? nome, string? sigla)
        {
            Id = id;
            Nome = nome;
            sigla = sigla;
        }                 
    }
}
