using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UtopiaCity.Models.Media
{
    public class Author
    {
        public Author()
        {
            DataCaptures = new HashSet<DataCapture>();
        }

        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        [Required]
        public string FName { get; set; }

        [Required]
        public string LName { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [ScaffoldColumn(false)]
        public ICollection<DataCapture> DataCaptures { get; set; }
    }
}