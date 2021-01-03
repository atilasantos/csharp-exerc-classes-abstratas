using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace AulaClassesAbstratas.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public abstract double TaxAmount();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Name}: $ {TaxAmount().ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}
