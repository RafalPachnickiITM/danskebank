using System;

namespace danskebank
{
    class Program
    {
        static void Main(string[] args)
        {
            double loanAmount;
            double loanDuration;
            Console.WriteLine("Loan amount: ");
            loanAmount = Double.Parse(Console.ReadLine());
            Console.WriteLine("Duration of loan (years): ");
            loanDuration = Double.Parse(Console.ReadLine());
            Loan loan = new Loan(loanAmount, loanDuration);
            loan.Overview();
        }
    }
}
