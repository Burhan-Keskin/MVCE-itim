using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer //Yazar
    {

        [Key]
        public int WriterID { get; set; }


        [StringLength(50)]
        public string WriterName { get; set; }

        [StringLength(50)]
        public string WriterSurName { get; set; }


        [StringLength(100)]
        public string WriterImage { get; set; }

        [StringLength(50)]
        public string WriterEmail { get; set; }

        [StringLength(20)]
        public string WriterPassword { get; set; }

        //Bir e çok ilişki kurarken bu şekilde kuruyoruz burda Yazar ile Başlık arasında bir ilişki kuruyoruz yazar 1 başlık çok olarak.
        public ICollection<Heading> Headings { get; set; }
        public ICollection<Content> Contents { get; set; }
    }
}
