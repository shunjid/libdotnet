using System.Collections.Generic;

namespace libdotnet.Data.Models
{
    public class Publisher
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        // Navigation Properties
        public List<Book> Books { get; set; }
    }
}