using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarket_mvp.Models
{
    internal class CategoriesModel
    {

        [DisplayName("Categories Id")]
        public int Id { get; set; }
        [DisplayName("Categories Name")]
        [Required(ErrorMessage ="Categories name is required")]
        [StringLength(80, MinimumLength =3, ErrorMessage = "Categories name must be between 3 and 80 characteres")]
        public string Name { get; set; }
        [DisplayName("Categories Description")]
        [Required(ErrorMessage = "Categories description is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Categories description must be between 3 and 200 characteres")]
        public string Description { get; set; }

        
    }
}
