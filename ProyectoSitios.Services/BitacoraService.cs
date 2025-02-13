using ProyectoSitios.Entities;
using ProyectoSitios.Repository;
using ProyectoSitios.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSitios.Services
{
    public class BitacoraService : IBitacoraService
    {
        private readonly BitacoraRepository _bitacoraRepository;

        public BitacoraService(BitacoraRepository bitacoraRepository)
        {
            _bitacoraRepository = bitacoraRepository;
        }

        public Task<IEnumerable<Bitacora>> GetAllAsync()
        {
            return _bitacoraRepository.GetAllAsync();
        }


    }
}
