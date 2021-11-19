using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DisneyWorld.Models
{
    public class Character
    {
        [Key]
        public int IdCharacter { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        public byte[] Photo { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        public int Age { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        public double Weight { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        [DataType(DataType.Text)]
        public string History { get; set; }
        public List<Movie> AssociatedMovies { get; set; }
    }
}
