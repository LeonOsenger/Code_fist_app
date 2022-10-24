using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_fist_app.Models
{
    public class Book
    {
        public Author Author { get; set; }

        public int AuthorId { get; set; }

        public int BookId { get; set; }

        public string Titel { get; set; }
    }
}
