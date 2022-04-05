using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Book:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AuthorId { get; set; }
        public int BookTypeId { get; set; }
        public int NumberOfPages { get; set; }
        public int YearOfPublication { get; set; }
        public int PublisherId { get; set; }
        public string Summary { get; set; }
    }
}
