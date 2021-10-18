using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample01_OnlineShoping.Controllers.DTO
{
    public class DTOCategoryProductController
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int Code { get; set; }
        public List<DTOProductController> Products { get; set; }
    }
}
