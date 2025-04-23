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
    // Implementation of IAutorService
    public class AutorService : IAutorService
    {
        // Database connection settings
        private string connectionString = "Data Source=DESKTOP-8SEKHL7;Initial Catalog=BibliotecaDB;Integrated Security=True";
        private SqlConnection connection;
        private SqlDataAdapter adapterAutor;
        private DataTable dataTable;

        public AutorService ()
        {
            connection = new SqlConnection(connectionString);
            adapterAutor = new SqlDataAdapter("SELECT * FROM Autor", connection);
            dataTable = new DataTable();

            // Fill dataTable with data from Author table
            adapterAutor.Fill(dataTable);
        }

        public List<AutorDTO> GetAutori()
        {
            List<AutorDTO> list = new List<AutorDTO>();

            foreach (DataRow row in dataTable.Rows)
            {
                AutorDTO autorDTO = AutorMapper.MapToDTO(row);
                list.Add(autorDTO);
            }

            return list;
        }

        public AutorDTO GetAutorByID(int id)
        {
            DataRow row = dataTable.AsEnumerable().FirstOrDefault(r => (int)r["IdAutor"] == id);
            if (row == null)
            {
                return null;
            }

            AutorDTO autorDTO = AutorMapper.MapToDTO(row);
            return autorDTO;
        }
    }
}
