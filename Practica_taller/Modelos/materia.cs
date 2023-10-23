using System.ComponentModel.DataAnnotations;

namespace Practica_taller.Modelos
{
    public class materia
    {
        // Llave primaria
        [Key]
        public int id_materia { get; set; }
        public string nombre_materia { get; set; }
        public int id_docente { get; set; }

    }
}
