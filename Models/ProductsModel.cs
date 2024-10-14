using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarket_mvp.Models
{
    internal class ProductsModel
    {

        [DisplayName ("Product Id")]
        public  int Id { get; set; }
        [DisplayName("Product Name")]
        [Required(ErrorMessage ="Product name is required")]
        [StringLength (80,MinimumLength =3, ErrorMessage ="Product name must be between 3 and 80 characters")]
        public string Name { get; set; }
        [DisplayName("Product Price")]
        [Required(ErrorMessage = "Product price is required")]
        public int Price { get; set; }

        [DisplayName("Product Stock")]
        [Required(ErrorMessage = "Product stock is required")]
        public int Stock { get; set; }
        [DisplayName("Product categorie id")]
        [Required(ErrorMessage = "Product categorie is required")]
        public int Categories_Id { get; set; }



    }
}
