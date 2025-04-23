using Bussiness.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.IService
{
    // Interface for the author service 
    public interface IAutorService
    {
        // Get all authors
        List<AutorDTO> GetAutori();
        // Get author by id
        AutorDTO GetAutorByID(int id);
    }
}
