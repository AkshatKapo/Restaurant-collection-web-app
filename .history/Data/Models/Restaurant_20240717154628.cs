using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_Collection.Data.Models
{
    public class Re
    {
        public int Id {get;set;}
        public required string Restaurant_Name { get; set;}
        public required string  Location { get; set; }
        public string Food {get; set;}
        public double Rate {get;set;} 
    }
}