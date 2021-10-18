using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;
using System.ComponentModel.DataAnnotations;


namespace Sample01_OnlineShoping.Controllers.DTO
{
    public class DTOProductController
    {
      
        public int ID { get; set; }
        public string ProductName { get; set; }
        public int Code { get; set; }
        [Display(Name = "UNIT Price")]
        public decimal UnitPrice { get; set; }
        [Display(Name = "Category")]
        public int CategoryRef { get; set; }
        public DTOCategoryProductController Category { get; set; }
    }
}
