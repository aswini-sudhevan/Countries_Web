using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Countries_Web.Entities
{
    public class Countries
    {
        [Key]
        public string Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        public string Currency { get; set; }
        public ICollection<Language> Languages { get; set; }
    }
}
