using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UtopiaCity.Models.Media
{
    public class DataCapture
    {
        public DataCapture()
        {
            Authors = new HashSet<Author>();
        }

        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        [Required]
        [MaxLength(100)]
        [MinLength(10)]
        public string Header { get; set; }

        [Required]
        [MinLength(100)]
        public string Content { get; set; }

        [Required]
        public string AuthorId { get; set; } // who wrote an information

        [ScaffoldColumn(false)]
        public bool? Status { get; set; } = true; // True - waiting | False = declined

        [Required]
        public bool Ready { get; set; } // True - ready to moderators check | False - in developement

        [ScaffoldColumn(false)]
        public ICollection<Author> Authors { get; set; }
    }
}
