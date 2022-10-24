using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_fist_app.Models
{
    public class Author
    {
        public int AuthorId { get; set; }

        public List<Book> Books { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }
    }
}
