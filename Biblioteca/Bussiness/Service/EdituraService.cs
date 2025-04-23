using Bussiness.DTOs;
using Bussiness.IService;
using Bussiness.Mapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Service
{
    public class EdituraService : IEdituraService
    {
        // Database connection settings
        private string connectionString = "Data Source=DESKTOP-8SEKHL7;Initial Catalog=BibliotecaDB;Integrated Security=True";
        private SqlConnection connection;
        private SqlDataAdapter adapterEditura;
        private DataTable dataTable;

        public EdituraService()
        {
            connection = new SqlConnection(connectionString);
            adapterEditura = new SqlDataAdapter("SELECT * FROM Editura", connection);
            dataTable = new DataTable();

            // Fill dataTable with data from Author table
            adapterEditura.Fill(dataTable);
        }

        public List<EdituraDTO> GetEditura()
        {
            List<EdituraDTO> list = new List<EdituraDTO>();

            foreach (DataRow row in dataTable.Rows)
            {
                EdituraDTO edituraDTO = EdituraMapper.MapToDTO(row);
                list.Add(edituraDTO);
            }

            return list;
        }

        public EdituraDTO GetEdituraByID(int id)
        {
            DataRow row = dataTable.AsEnumerable().FirstOrDefault(r => (int)r["IdEditura"] == id);
            if (row == null)
            {
                return null;
            }

            EdituraDTO edituraDTO = EdituraMapper.MapToDTO(row);
            return edituraDTO;
        }
    }
}
