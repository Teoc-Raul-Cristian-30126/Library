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
    public class CarteService : ICarteService
    {
        // Database connection settings
        private string connectionString = "Data Source=DESKTOP-8SEKHL7;Initial Catalog=BibliotecaDB;Integrated Security=True";
        private SqlConnection connection;
        private SqlDataAdapter adapterCarte;
        private SqlDataAdapter adapterCarteAutor;
        private SqlCommandBuilder builderCarte;
        private SqlCommandBuilder builderCarteAutor;
        private DataSet dataSet;

        public CarteService()
        {
            connection = new SqlConnection(connectionString);
            adapterCarte = new SqlDataAdapter("SELECT * FROM Carte", connection);
            adapterCarteAutor = new SqlDataAdapter("SELECT * FROM CarteAutor", connection);
            dataSet = new DataSet("Biblioteca");

            builderCarte = new SqlCommandBuilder(adapterCarte);
            builderCarteAutor = new SqlCommandBuilder(adapterCarteAutor);

            // Fill dataSet with data from Book table and BookAuthor table
            adapterCarte.Fill(dataSet, "Carte");
            adapterCarteAutor.Fill(dataSet, "CarteAutor");
        }

        public List<CarteDTO> GetCarti()
        {
            List<CarteDTO> list = new List<CarteDTO>();

            foreach (DataRow row in dataSet.Tables["Carte"].Rows)
            {
                CarteDTO carteDTO = CarteMapper.MapToDTO(row, dataSet.Tables["CarteAutor"]);
                list.Add(carteDTO);
            }

            return list;
        }

        public CarteDTO GetCarteByID(int id)
        {
            DataRow row = dataSet.Tables["Carte"].AsEnumerable().FirstOrDefault(r => (int)r["IdCarte"] == id);
            if (row == null)
            {
                return null;
            }

            CarteDTO carteDTO = CarteMapper.MapToDTO(row, dataSet.Tables["CarteAutor"]);
            return carteDTO;
        }

        public void AdaugaCarte(CarteDTO carte)
        {
            DataRow row = dataSet.Tables["Carte"].NewRow();
            row["Titlu"] = carte.Titlu;
            row["AnPublicare"] = carte.AnPublicare;
            row["Descriere"] = carte.Descriere;
            row["IdEditura"] = carte.IdEditura;

            dataSet.Tables["Carte"].Rows.Add(row);
            adapterCarte.Update(dataSet, "Carte");

            RefreshData();

            carte.IdCarte = GetLastCarteId();
            
            foreach (int idAutor in carte.IdAutori)
            {
                DataRow autorCarteRow = dataSet.Tables["CarteAutor"].NewRow();
                autorCarteRow["IdCarte"] = carte.IdCarte;
                autorCarteRow["IdAutor"] = idAutor;
                dataSet.Tables["CarteAutor"].Rows.Add(autorCarteRow);
            }

            adapterCarteAutor.Update(dataSet, "CarteAutor");
        }

        // Get last id from Book table
        private int GetLastCarteId()
        {
            int lastId = dataSet.Tables["Carte"].AsEnumerable().Where(row => !row.IsNull("IdCarte")).Max(row => row.Field<int>("IdCarte"));
            return lastId;
        }

        public void RefreshData()
        {
            dataSet.Clear();
            adapterCarte.Fill(dataSet, "Carte");
            adapterCarteAutor.Fill(dataSet, "CarteAutor");
        }

        public void ModificaCarte(CarteDTO carte)
        {
            DataRow row = dataSet.Tables["Carte"].AsEnumerable().FirstOrDefault(r => (int)r["IdCarte"] == carte.IdCarte);
            if (row == null)
            {
                return;
            }

            row["Titlu"] = carte.Titlu;
            row["AnPublicare"] = carte.AnPublicare;
            row["Descriere"] = carte.Descriere;
            row["IdEditura"] = carte.IdEditura;

            adapterCarte.Update(dataSet, "Carte");

            DataRow[] autorRows = dataSet.Tables["CarteAutor"].Select($"IdCarte = {carte.IdCarte}");
            foreach (DataRow autor in autorRows)
            {
                autor.Delete();
            }

            foreach (int idAutor in carte.IdAutori)
            {
                DataRow autorCarteRow = dataSet.Tables["CarteAutor"].NewRow();
                autorCarteRow["IdCarte"] = carte.IdCarte;
                autorCarteRow["IdAutor"] = idAutor;
                dataSet.Tables["CarteAutor"].Rows.Add(autorCarteRow);
            }

            adapterCarteAutor.Update(dataSet, "CarteAutor");
        }

        public void StergeCarte(int id)
        {
            DataRow[] autorRows = dataSet.Tables["CarteAutor"].Select($"IdCarte = {id}");
            foreach (DataRow autor in autorRows)
            {
                autor.Delete();
            }

            adapterCarteAutor.Update(dataSet, "CarteAutor");

            DataRow carteRow = dataSet.Tables["Carte"].AsEnumerable().FirstOrDefault(r => (int)r["IdCarte"] == id);
            if (carteRow != null)
            {
                carteRow.Delete();
                adapterCarte.Update(dataSet, "Carte");
            }
        }

        public List<CarteDTO> FiltreazaCarti(int anMin, int anMax, int idEditura)
        {
            return GetCarti().Where(c => c.AnPublicare >= anMin && c.AnPublicare <= anMax)
                             .Where(c => c.IdEditura == idEditura).ToList();
        }
    }
}
