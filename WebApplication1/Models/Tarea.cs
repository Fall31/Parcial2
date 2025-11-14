namespace WebApplication1.Models
{
    public class Tarea
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public DateOnly FechaCreacion { get; set; } 
        public string Estado { get; set; }
        public string Rol {  get; set; }
        public string Prioridad { get; set; }
    }
}
