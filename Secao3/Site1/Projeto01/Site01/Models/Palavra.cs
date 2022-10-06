using Site01.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site01.Models
{
    public class Palavra
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Dificuldade Nivel { get; set; }
    }
}
