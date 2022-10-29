
namespace Cadastro.Entities
{
    class LegalEntity : Person
    {

        public int EmployeesQuantity { get; set; }

        public LegalEntity(string name, double anualIncome, int employeesQuantity) : base(name, anualIncome)
        {
            EmployeesQuantity = employeesQuantity;
        }

        public override double TaxCalculation()
        {
            double tax = 0.0;

            if (EmployeesQuantity > 10)
                tax = AnualIncome * 0.14;

            else
                tax = AnualIncome * 0.16;


            return tax;
        }
    }
}
