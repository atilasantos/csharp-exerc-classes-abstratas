using System;
using System.Collections.Generic;
using System.Text;

namespace AulaClassesAbstratas.Entities
{
    class CompanyTaxPayer : TaxPayer
    {
        public int EmployeeQuantity { get; set; }

        public CompanyTaxPayer() { }
        public CompanyTaxPayer(string name, double anualIncome, int employeeQuantity)
        {
            Name = name;
            AnualIncome = anualIncome;
            EmployeeQuantity = employeeQuantity;
        }

        public override double TaxAmount()
        {
            double taxAmount;
            if (EmployeeQuantity > 10)
            {
                taxAmount = AnualIncome * 0.14;
            }
            else
            {
                taxAmount = AnualIncome * 0.16;
            }
            return taxAmount;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
