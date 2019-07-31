using System;
using System.Collections.Generic;
using System.Text;

namespace Interfacev2Project {
    class Service : ICalcSales {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Rate { get; set; }
        public int Hours { get; set; }


        public decimal CalcSales() {
            return Rate * Hours;
        }

        public string About() {
            return "About Services.";
        }

        public Service(int Id, string Name, int Rate, int Hours) {
            this.Id = Id;
            this.Name = Name;
            this.Rate = Rate;
            this.Hours = Hours;
        }

    }
}
