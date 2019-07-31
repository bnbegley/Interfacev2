using System;
using System.Collections.Generic;
using System.Text;

namespace Interfacev2Project {
    class Product : ICalcSales {

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Units { get; set; }

        public decimal CalcSales() {
            return Price * Units;
        }

        public string About() {
            return "About Products.";
        }

        public Product (int Id, string Name, decimal Price, int Units) {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
            this.Units = Units;
        }

      
    }
}
