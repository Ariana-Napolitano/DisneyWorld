using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyWorld.Models
{
    public class SimpleCharacterDTO:Identifiable
    {
        
        public byte[] Photo { get; set; }
        public string Name { get; set; }
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
