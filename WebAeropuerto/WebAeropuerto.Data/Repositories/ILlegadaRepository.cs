using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAeropuerto.Model;

namespace WebAeropuerto.Data.Repositories
{
    public interface ILlegadaRepository
    {
        Task<IEnumerable<Llegada>> GetAllLlegadas();
        Task<Llegada> GetDetails(int id);

        Task<bool> InsertLlegada(Llegada llegada);

        Task<bool> UpdateLlegada(Llegada llegada);

        Task<bool> DeleteLlegada(Llegada llegada);

    }
}
