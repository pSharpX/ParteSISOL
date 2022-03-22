 using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParteSISOL.Servicios;
using Microsoft.Data.SqlClient;
using Dapper;
using ParteSISOL.Models;

namespace ParteSISOL.Controllers
{
    public class EspecialidadDenominacionController : Controller
    {
        private readonly IRepositorioEspecialidadDenominacion repositorioEspecialidadDenominacion;

        public EspecialidadDenominacionController(IRepositorioEspecialidadDenominacion especialidadDenominacion)
        {
            this.repositorioEspecialidadDenominacion = especialidadDenominacion;
        }
        public async Task<IActionResult> Index()
        {
            var especialidaddenominacion = await repositorioEspecialidadDenominacion.Obtener();
            var modelo = new HomeIndexViewModel()
            {
                especialidadDenominacion = especialidaddenominacion
            };
            return View(modelo);
        }

        //Mostrar la lista de las sedes por especialidades
        public async Task<IActionResult> Sedes(int Idespecialidad )
        {
            var especialidaddenominacion = await repositorioEspecialidadDenominacion.ObtenerSedePorEspecialidad(Idespecialidad);
            var modelo = new HomeIndexViewModel()
            {
                especialidadDenominacion = especialidaddenominacion
            };
            return View("Sedes",modelo.especialidadDenominacion);
        }
        public async Task<IActionResult> SedeEspecialidad(int Idespecialidad = 2)
        {
            var especialidadDenominacion = await repositorioEspecialidadDenominacion.ObtenerDatosEspecialidad(Idespecialidad);
            var modelo = new HomeIndexViewModel()
            {
                especialidadDenominacion = especialidadDenominacion
            };
            
            return View("SedeEspecialidad", modelo.especialidadDenominacion);
        }


    }
}
