using Dapper;
using Microsoft.Data.SqlClient;
using ParteSISOL.Models;
using System.Collections.Generic;

namespace ParteSISOL.Servicios
{
    public interface IRepositorioEspecialidad
    {
        Task<IEnumerable<Especialidad>> Obtener();
    }
    public class RepositorioEspecialidad:IRepositorioEspecialidad
    {
        private readonly string _connectionString;

        public RepositorioEspecialidad(IConfiguration configuration) 
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }
        public async Task<IEnumerable<Especialidad>> Obtener() 
        {
            var sqlQuery = "select e.Idespecialidad, e.Especialidad as EspecialidadName, d.Iddenominacion,d.Denominacion from Especialidad e inner join Denominacion d on d.Iddenominacion=e.Iddenominacion";
            var especialidad = new List<Especialidad>();

            using (var connection = new SqlConnection(_connectionString)) 
            {
                return await connection.QueryAsync<Especialidad>(sqlQuery);

            }

        
        }
    }
}
