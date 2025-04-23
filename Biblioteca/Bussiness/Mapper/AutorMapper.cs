using Bussiness.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Mapper
{
    public static class AutorMapper
    {
        // Convert row to DTO object
        public static AutorDTO MapToDTO(DataRow row)
        {
            return new AutorDTO
            {
                IdAutor = (int)row["IdAutor"],
                NumeAutor = row["NumeAutor"].ToString(),
                PrenumeAutor = row["PrenumeAutor"].ToString()
            };
        }
    }
}
