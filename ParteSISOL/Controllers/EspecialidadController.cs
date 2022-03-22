using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Dapper;
using ParteSISOL.Models;
using ParteSISOL.Servicios;

namespace ParteSISOL.Controllers
{
    public class EspecialidadController : Controller
    {
        private readonly IRepositorioEspecialidad repositorioEspecialidad;

        public EspecialidadController(IRepositorioEspecialidad repositorioEspecialidad) 
        {
            this.repositorioEspecialidad = repositorioEspecialidad;
        }

        public async Task<IActionResult> Index()
        {
            var especialidades = await repositorioEspecialidad.Obtener();
            return View(especialidades);
        }
    }
}
