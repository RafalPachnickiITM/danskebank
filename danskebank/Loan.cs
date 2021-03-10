using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace danskebank
{
    public class Loan
    {
        private double AnnualInterestRate { get { return 0.05; } }
        private double NumberOfPeriodsInAnnual { get { return 12; } }
        private double TotalNumberOfInterestPeriods { get { return loanDuration * NumberOfPeriodsInAnnual; } }
        private double PeriodicInterestRate { get { return AnnualInterestRate / NumberOfPeriodsInAnnual; } }
        private double AdministrationFee { get { return (loanAmount * 0.01) <= 10000 ? (loanAmount * 0.01) : 10000; } }
        private double MonthlyPayment
        {
            get
            {
                return (loanAmount * PeriodicInterestRate) / (1 - Math.Pow(1 + PeriodicInterestRate,-TotalNumberOfInterestPeriods));
            }
        }
        private double TotalAmountPaid { get { return (MonthlyPayment * loanDuration * NumberOfPeriodsInAnnual) - loanAmount; } }
        double loanAmount;
        double loanDuration;

        public Loan(double loanAmount, double loanDuration)
        {
            this.loanAmount = loanAmount;
            this.loanDuration = loanDuration;
        }


        public void Overview()
        {
            Console.WriteLine("----- Loan Overview -----");
            Console.WriteLine("Loan amount: {0}", loanAmount);
            Console.WriteLine("Duration of loan (years): {0}", loanDuration);
            Console.WriteLine("Monthly payment: {0}", Math.Round(MonthlyPayment,2));
            Console.WriteLine("Total amount paid as interest rate: {0}", Math.Round(TotalAmountPaid,2));
            Console.WriteLine("Administration fee: {0}", AdministrationFee);
        }
    }
}
