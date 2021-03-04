using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebCoreAssignment.Models
{
    public class BlogPage
    {
        [MaxLength(50)]
        public string Title { get; set; }

        [MaxLength(10000)]
        public string Content { get; set; }

        public string NewAuthor { get; set; }

        public DateTime PublishDate { get; set; }

    }
}
