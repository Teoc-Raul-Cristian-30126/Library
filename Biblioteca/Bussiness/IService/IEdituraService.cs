using Bussiness.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.IService
{
    // Interface for the book publisher service
    public interface IEdituraService
    {
        // Get all publishers
        List<EdituraDTO> GetEditura();
        // Get publisher by id
        EdituraDTO GetEdituraByID(int id);
    }
}
