using ProyectoSitios.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSitios.Services.Abstract
{
    public interface IBitacoraService
    {
        Task<IEnumerable<Bitacora>> GetAllAsync();

       
    }
}
