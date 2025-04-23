using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussiness.DTOs;
using System.Data;

namespace Bussiness.Mapper
{
    public static class CarteMapper
    {
        // Convert row to DTO object
        public static CarteDTO MapToDTO(DataRow row, DataTable autoriCarte)
        {
            return new CarteDTO
            {
                IdCarte = (int)row["IdCarte"],
                Titlu = row["Titlu"].ToString(),
                AnPublicare = (int)row["AnPublicare"],
                Descriere = row["Descriere"].ToString(),
                IdEditura = (int)row["IdEditura"],
                IdAutori = autoriCarte.AsEnumerable().Where(r => (int)r["IdCarte"] == (int)row["IdCarte"])
                                                     .Select(r => (int)r["IdAutor"])
                                                     .ToList()
            };
        }
    }
}
