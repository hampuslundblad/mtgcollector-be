using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mtgcollector.Models
{
    public class Card
    {

        public int? CollectionId {get; set;}
        public Collection? Collection {get;set;}
        
        public required string Name { get; set; }
        public required string ImageUrl { get; set; }
        public required string Set { get; set; }
        public required int Quantity { get; set; }
        public required bool Foil { get; set; }
        public required decimal Price { get; set; }
        
    }
}