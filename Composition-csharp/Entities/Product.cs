using System;
using System.Collections.Generic;
using System.Text;

namespace Composition_csharp.Entities
{
    class Product
    {
        public string Name { get; set; }
        public Double Price { get; set; }
        public Product(){ }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
