using CommonFunctionalities.Services.Interfaces;

namespace CommonFunctionalities.Services
{
public class TaxService : ITaxService
    {
        private const double VatPercentage = 0.23;
        private const double GovermentPercentaagee = 0.17;
        public double Calculate(double income)
        {
            var vatTax = CalculateVat(income);
            var govermentTax = CalculateGovermentTax(income, vatTax);
            return vatTax + govermentTax;
        }
        private double CalculateVat(double income)
        {
            return income * VatPercentage;
        }

        private double CalculateGovermentTax(double income, double vatTax)
        {
            return (income - vatTax) * GovermentPercentaagee;
        }
    }
}