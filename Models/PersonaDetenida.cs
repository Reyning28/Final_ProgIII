namespace RedadasMigracion.Models
{
    public class PersonaDetenida
    {
        public int Id { get; set; }
        public DateTime FechaDetencion { get; set; } =DateTime.Now;
        public string NombreApellido { get; set; } = string.Empty;
        public string NumeroPasaporte { get; set; } = string.Empty;
        public DateTime FechaNacimiento { get; set; }
        public string Coordenadas { get; set; } = string.Empty;
    }
}
