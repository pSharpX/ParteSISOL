namespace ParteSISOL.Models
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Especialidad> Especialidad { get; set; }

        public IEnumerable<Denominacion> Denominacions { get; set; }
        public IEnumerable<Sede> Sede { get; set; }

        public IEnumerable<ServiciosContratados> ServiciosContratados { get; set; }
        public IEnumerable<EspecialidadDenominacion> especialidadDenominacion { get; set; }


    }
}
