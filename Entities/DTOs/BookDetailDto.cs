using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO_s
{
    public class BookDetailDto:IDto
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public int YearOfPublication { get; set; }
        public string AuthorName { get; set; }
        public string PublisherName { get; set; }
        public string BookType { get; set; }
    }
}
