using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Models.DTOs;
namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TareaController : ControllerBase
    {
        public static string[] Tarea = new[]
            {
                "Planteamiento requerimientos funcionales", "Desarrollo frontend", "Desarrollo backend", "Desarrollo base de datos", "Desarrollo DFD"
            };
        public static string[] Prioridad = new[]
            {
                "Baja", "Media", "Alta"
            };
        public static string[] Rol = new[]
            {
                "Developer", "Tester", "Lider"
            };
        public static string[] Estado = new[]
            {
                "ToDo", "InProgress", "Done"
            };
        private readonly ILogger<TareaController> _logger;
        public TareaController(ILogger<TareaController> logger)
        {
            _logger = logger;
        }

        [HttpPut (Name ="Crear tarea")]
        public IEnumerable<Tarea> Put()
        {
            int Id = 0;
            return Enumerable.Range(0, 4).Select(index => new Tarea
            {
                Id = Id++,
                Titulo = Tarea[Random.Shared.Next(Tarea.Length)],
                FechaCreacion =  DateOnly.FromDateTime(DateTime.Now),
                Estado = Estado[Random.Shared.Next(Estado.Length)],
                Prioridad = Prioridad[Random.Shared.Next(Prioridad.Length)],
                Rol = Rol[Random.Shared.Next(Rol.Length)]
            })
            .ToList();
        }
    }
}
