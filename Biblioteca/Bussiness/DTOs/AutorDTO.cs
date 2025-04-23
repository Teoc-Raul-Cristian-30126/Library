using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.DTOs
{
    // DTO for the author 
    public class AutorDTO
    {
        public int IdAutor { get; set; }
        public string NumeAutor { get; set; }
        public string PrenumeAutor { get; set; }
        public string NumeComplet => $"{PrenumeAutor} {NumeAutor}";
    }
}
