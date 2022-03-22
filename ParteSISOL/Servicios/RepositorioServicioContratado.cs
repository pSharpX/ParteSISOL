using Microsoft.Data.SqlClient;
using ParteSISOL.Models;
using Dapper;

namespace ParteSISOL.Servicios
{
    public interface IRepositorioServicioContratado
    {
        Task<IEnumerable<ServiciosContratados>> ObtenerEspecialidadPorSede(int Idsede);
    }
    public class RepositorioServicioContratado: IRepositorioServicioContratado
    {
        private readonly string _connectionString;

        public RepositorioServicioContratado(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }
        public async Task<IEnumerable<ServiciosContratados>> ObtenerEspecialidadPorSede(int Idsede)
        {
            using var connection = new SqlConnection(_connectionString);
            return await connection.QueryAsync<ServiciosContratados>
                                                ("[ListarEspecialidadesxSede]",
                                                new
                                                {
                                                    Idsede
                                                },
                                                commandType: System.Data.CommandType.StoredProcedure);



        }
    }
}
