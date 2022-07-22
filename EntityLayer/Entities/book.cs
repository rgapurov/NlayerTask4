using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class book
    {
        [Key]
        public int bookID { get; set; }
        [StringLength(30)]
        public string bookName { get; set; }
        [StringLength(30)]
        public string bookAuthor { get; set; }
        public virtual publisher publishers { get; set; }

    }
}
