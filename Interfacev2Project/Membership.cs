using System;
using System.Collections.Generic;
using System.Text;

namespace Interfacev2Project {
    public class Membership : ICalcSales {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Fee { get; set; }
        public int Units { get; set; }

        public decimal CalcSales() {
            return (decimal) Fee * Units;
        }

        public Membership (int Id, string Name, int Fee, int Units) {
            this.Id = Id;
            this.Name = Name;
            this.Fee = Fee;
            this.Units = Units;
        }
    }
}
