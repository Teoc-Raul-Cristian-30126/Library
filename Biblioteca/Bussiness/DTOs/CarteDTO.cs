using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.DTOs
{
    // DTO for the book
    public class CarteDTO
    {
        public int IdCarte { get; set; }
        public string Titlu { get; set; }
        public int AnPublicare { get; set; }
        public string Descriere { get; set; }
        public int IdEditura { get; set; }
        public List<int> IdAutori { get; set; } = new List<int>();
    }
}
