
namespace Cadastro.Entities
{
    class IndividualEntity : Person
    {

        public double HealthExpenditures { get; set; }

        public IndividualEntity(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }


        public override double TaxCalculation()
        {
            double tax = 0.0;
            if (AnualIncome < 20000.00)
            {
                tax = AnualIncome * 0.15;

                if (HealthExpenditures > 0)
                    tax = tax - HealthExpenditures * 0.5;
            }

            else if (AnualIncome >= 20000.00)
            {
                tax = AnualIncome * 0.25;

                if (HealthExpenditures > 0)
                    tax = tax - HealthExpenditures * 0.5;
            }
            return tax;
        }
    }
}
