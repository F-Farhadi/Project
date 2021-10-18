using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample01_OnlineShoping.Models.DomainModel.Aggregations.ProductAggregation
{
    public class ProductCategory
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int Code { get; set; }
        public List<Product> Products { get; set; }
    }
}
