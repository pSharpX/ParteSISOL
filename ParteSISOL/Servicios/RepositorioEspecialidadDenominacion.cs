using Microsoft.Data.SqlClient;
using ParteSISOL.Models;
using Dapper;

namespace ParteSISOL.Servicios
{
    public interface IRepositorioEspecialidadDenominacion
    {
        Task<IEnumerable<EspecialidadDenominacion>> Obtener();
        Task<IEnumerable<EspecialidadDenominacion>> ObtenerDatosEspecialidad(int idsede);
        Task<IEnumerable<EspecialidadDenominacion>> ObtenerSedePorEspecialidad(int idespecialidad);
    }
    public class RepositorioEspecialidadDenominacion: IRepositorioEspecialidadDenominacion
    {
        private readonly string _connectionString;

        public RepositorioEspecialidadDenominacion(IConfiguration configuration) 
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }
        public async Task<IEnumerable<EspecialidadDenominacion>> Obtener()
        {
            var sqlQuery = "select e.Idespecialidad, e.Especialidad, d.Denominacion from Especialidad e inner join Denominacion d on d.Iddenominacion=e.Iddenominacion order by d.Denominacion";
            var especialidad = new List<EspecialidadDenominacion>();

            using (var connection = new SqlConnection(_connectionString))
            {
                return await connection.QueryAsync<EspecialidadDenominacion>(sqlQuery);

            }

        }
        public async Task<IEnumerable<EspecialidadDenominacion>> ObtenerSedePorEspecialidad(int Idespecialidad)
        {
            using var connection = new SqlConnection(_connectionString);
            return await connection.QueryAsync<EspecialidadDenominacion>
                                                ("ListarSedePorEspecialidad",
                                                new
                                                {
                                                    Idespecialidad
                                                },
                                                commandType: System.Data.CommandType.StoredProcedure);
            


        }
        public async Task<IEnumerable<EspecialidadDenominacion>> ObtenerDatosEspecialidad(int idsede)
        {
            using var connection = new SqlConnection(_connectionString);
            return await connection.QueryAsync<EspecialidadDenominacion>
                                                ("ListarDatosSedeEspecialidad",
                                                new
                                                {
                                                    idsede
                                                },
                                                commandType: System.Data.CommandType.StoredProcedure);



        }

    }
}
