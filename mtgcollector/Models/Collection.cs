using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mtgcollector.Models
{
    public class Collection
    {
        public int Id { get; set; }
        public List<Card> Cards { get; set; } = new List<Card>();
    }
}