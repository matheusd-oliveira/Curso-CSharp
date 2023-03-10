namespace ExLinq02.Entities
{
    internal class Employees
    {
        public string Name { get; set; }
        public string Mail { get; set; }
        public double Salary { get; set; }

        public Employees(string name, string mail, double salary)
        {
            Name = name;
            Mail = mail;
            Salary = salary;
        }

    }
}
