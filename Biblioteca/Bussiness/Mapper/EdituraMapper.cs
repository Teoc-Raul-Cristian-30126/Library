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
    public class EdituraMapper
    {
        // Convert row to DTO object
        public static EdituraDTO MapToDTO(DataRow row)
        {
            return new EdituraDTO
            {
                IdEditura = (int)row["IdEditura"],
                NumeEditura = row["NumeEditura"].ToString()
            };
        }
    }
}
