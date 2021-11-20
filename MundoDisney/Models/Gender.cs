using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DisneyWorld.Models
{
    public class Gender:Identifiable
    {
        [Key]
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [Required(ErrorMessage = "{0} es requerido")]
        public byte[] Picture { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        [DataType(DataType.Text)]
        public string GenderName { get; set; }
        public List<Movie> AssociatedMovies { get; set; }
        
    }
}
