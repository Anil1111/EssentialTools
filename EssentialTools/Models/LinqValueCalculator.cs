using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialTools.Models
{
    //note we don't need to add a reference to Poructs because we are within the same namespace.
    public class LinqValueCalculator : IValueCalculator {
        public decimal ValueProducts(IEnumerable<Product> products)
        {
            return products.Sum(p => p.Price); //note "Sum" is a linq extension method
                                                 
        }
    }
}