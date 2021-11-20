using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DisneyWorld.Models
{
    public class Movie:Identifiable
    {
        [Key]
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [Required]
        public byte[] Image { get; set; }
        [Required]
        public string Title { get; set; }
        [Timestamp]
        [Required]
        public DateTime Date { get; set; }
        [Range(1,5)]
        public int Score { get; set; }
        public List<Character> AssociatedCharacters { get; set; }
       
      
    }
}
