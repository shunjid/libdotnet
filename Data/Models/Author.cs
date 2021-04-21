using System.Collections.Generic;

namespace libdotnet.Data.Models
{
    public class Author
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<BookAuthor> BookAuthors { get; set; }
    }
}