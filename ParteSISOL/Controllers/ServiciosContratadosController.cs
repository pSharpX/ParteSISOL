using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Dapper;
using ParteSISOL.Models;
using ParteSISOL.Servicios;


namespace ParteSISOL.Controllers
{
    public class ServiciosContratadosController : Controller
    {
        private readonly IRepositorioServicioContratado repositorioServiciosContratados;

        public ServiciosContratadosController(IRepositorioServicioContratado repositorioServiciosContratados)
        {
            this.repositorioServiciosContratados = repositorioServiciosContratados;
        }
        public async Task<IActionResult> _EspecialidadPorSede(int Idespecialidad)
        {
            var serviciosContratados = await repositorioServiciosContratados.ObtenerEspecialidadPorSede(Idespecialidad);
            var modelo = new HomeIndexViewModel()
            {
                ServiciosContratados = serviciosContratados
            };
            return View("_EspecialidadPorSede", modelo.ServiciosContratados);
        }

    }
}
