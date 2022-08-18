using System.Collections.Generic;

namespace AsmApp.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public ICollection<Book> Books { get; set; } //1 - many
    }
}
