using Dapper;
using ProyectoSitios.Entities;

namespace ProyectoSitios.Repository
{
    public class BitacoraRepository
    {
        private readonly IDbConnectionFactory _dbConnectionFactory;

        public BitacoraRepository(IDbConnectionFactory dbConnectionFactory)
        {
            _dbConnectionFactory = dbConnectionFactory;
        }

        public async Task<IEnumerable<Bitacora>> GetAllAsync()
        {
            using (var connection = _dbConnectionFactory.CreateConnection())
            {
                return await connection.QueryAsync<Bitacora>("CALL SP_Bitacora();");
            }
            
        }

    }
}
