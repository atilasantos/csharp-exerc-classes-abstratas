using System;
using System.Collections.Generic;
using System.Text;

namespace AulaClassesAbstratas.Entities
{
    class IndividualTaxPayer : TaxPayer
    {
        public double HealthCosts { get; set; }

        public IndividualTaxPayer() { }
        public IndividualTaxPayer(string name, double anualIncome, double healthCosts)
        {
            Name = name;
            AnualIncome = anualIncome;
            HealthCosts = healthCosts;
        }

        public override double TaxAmount()
        {
            double healthRefund = HealthCosts * 0.5;
            double taxAmount;

            if (AnualIncome > 20000.00)
            {
                taxAmount = (AnualIncome * 0.25) - healthRefund;
            }
            else
            {
                taxAmount = (AnualIncome * 0.15) - healthRefund;
            }
            return taxAmount;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
