using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Product
    {
        [Key]
        public int productId { get; set; }

        public string productName { get; set; }

        public string productShortDescription { get; set; }

        public string productLongDescription { get; set; }

        public string productPrice { get; set; }

        public string productImageUrl { get; set; }

        public string productIngredients { get; set; }

        public string productionPlace { get; set; }

        public int categoryId { get; set; }

        public Category Category { get; set; }




    }
}
