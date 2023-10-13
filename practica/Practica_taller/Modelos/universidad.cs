using System.ComponentModel.DataAnnotations;

namespace Practica_taller.Modelos
{
    public class universidad
    {
        // Llave primaria
        [Key]
        public int id_universidad { get; set; }
        public string nombre_universidad { get; set; }
    }
}
