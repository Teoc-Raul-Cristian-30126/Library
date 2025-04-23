using Bussiness.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.IService
{
    // Interface for the book service
    public interface ICarteService
    {
        // Get all books
        List<CarteDTO> GetCarti();
        // Get book by id
        CarteDTO GetCarteByID(int id);
        // Add book in table
        void AdaugaCarte(CarteDTO carte);
        // Modify book from table 
        void ModificaCarte(CarteDTO carte);
        // Delete book from table
        void StergeCarte(int id);
        // Get all books from a certain year with a publisher
        List<CarteDTO> FiltreazaCarti(int anMin, int anMax, int idEditura);
        // Refresh table
        void RefreshData();
    }
}
