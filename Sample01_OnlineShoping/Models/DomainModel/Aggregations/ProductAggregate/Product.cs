using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample01_OnlineShoping.Models.DomainModel.Aggregations.ProductAggregation
{
    public class Product
    {

        public int ID { get; set; }
        public string ProductName { get; set; }
        public int Code { get; set; }
        public decimal UnitPrice { get; set; }
        public int CategoryRef { get; set; }
        public ProductCategory Category { get; set; }

    }
}
