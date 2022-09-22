using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category //Kategori
    {
        [Key]
        public int CategoryID { get; set; }

        [StringLength(50)]
        public string CategoryName { get; set; }

        [StringLength(200)]
        public string CategoryDescription { get; set; }

        public bool CategoruStatus { get; set; }

        // Ben bu sınıfa bağlı bir colection oluşturucam
        public ICollection<Heading> Headings { get; set; }

    }
}
