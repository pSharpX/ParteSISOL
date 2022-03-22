using Microsoft.Data.SqlClient;
using Dapper;
namespace ParteSISOL.Models.Servicios
{
    public interface IRepositorioSede
    {
        //Task<IEnumerable> ListarSede(int idespecialidad);
    }
    public class RepositorioSede: IRepositorioSede
    {
        private readonly string _connectionString;

        public RepositorioSede(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaaultConnection");
        }
        //public async Task<IEnumerable> ListarSede(int idespecialidad)
        //{
        //    //using var connection = new SqlConnection(_connectionString);
        //    //return await connection.QueryAsync<ServiciosContratados>
        //    //                              ("ListarSedePorEspecialidad",
        //    //                              new
        //    //                              {
        //    //                                  idEspecialidad
        //    //                              },
        //    //                              commandType: System.Data.CommandType.StoredProcedure);

        //}
    }
}
