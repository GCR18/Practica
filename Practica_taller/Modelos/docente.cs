using System.ComponentModel.DataAnnotations;

namespace Practica_taller.Modelos
{
    public class docente
    {
        // Llave primaria
        [Key]
        public int id_docente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string ubicacion { get; set; }
        public bool sexo { get; set; }
        public string ci { get; set; }
        public int id_universidad { get; set; }
    }
}
