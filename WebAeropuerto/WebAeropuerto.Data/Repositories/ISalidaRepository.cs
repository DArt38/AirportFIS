using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAeropuerto.Model;

namespace WebAeropuerto.Data.Repositories
{
    public interface ISalidaRepository
    {
        Task<IEnumerable<Salida>> GetAllSalidas();

        Task<Salida> GetSalidaDetails(int id);

        Task<bool> InsertSalida(Salida salida);

        Task<bool> UpdateSalida(Salida salida);

        Task<bool> DeleteSalida(Salida salida);

    }
}
