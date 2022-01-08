using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
   public class Author
    {
        [Key]
        public int  AuthorID { get; set; }
        public string  AuthorName { get; set; }
        public string AuthorAbout { get; set; }
        public string AuthorImage { get; set; }
        public string AuthorMail { get; set; }
        public string AuthorPassword { get; set; }
        public bool AuthorStatus { get; set; }

        public List<Blog> Blogs { get; set; }
    }
}
