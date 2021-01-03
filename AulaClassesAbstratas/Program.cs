using AulaClassesAbstratas.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace AulaClassesAbstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> taxPayerList = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine($"Tax payer #{i + 1} data:");
                Console.Write("Individual or company (i/c)? ");
                char type = Convert.ToChar(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double income = Convert.ToDouble(Console.ReadLine(),CultureInfo.InvariantCulture);

                TaxPayer payer;

                if (type == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthCosts = Convert.ToDouble(Console.ReadLine(),CultureInfo.InvariantCulture);
                    payer = new IndividualTaxPayer(name, income, healthCosts);
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employee = Convert.ToInt32(Console.ReadLine());
                    payer = new CompanyTaxPayer(name, income, employee);
                }
                taxPayerList.Add(payer);
            }

            double sumTaxes = 0;
            Console.WriteLine("TAXES PAID:");
            foreach (TaxPayer payer in taxPayerList)
            {
                sumTaxes += payer.TaxAmount();
                Console.WriteLine(payer);
            }
            Console.WriteLine($"\nTOTAL TAXES: $ {sumTaxes.ToString("F2",CultureInfo.InvariantCulture)}");

        }
    }
}
