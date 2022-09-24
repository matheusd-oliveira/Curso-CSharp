using System;
using System.Globalization;

namespace ExercicioNotaDoAluno
{
    class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3, total;

        public override string ToString()
        {
            double total = Nota1 + Nota2 + Nota3;
            double restante = 60 - total;

            if (total >= 60)
            {
                return "Nota Final = " 
                    + total.ToString("F2", CultureInfo.InvariantCulture)
                    + "\nAPROVADO";
                
            }
            else
            {
                return "Nota Final = " 
                    + total.ToString("F2", CultureInfo.InvariantCulture)
                    + "\nREPROVADO"
                    + "\nFaltaram " + restante.ToString("F2", CultureInfo.InvariantCulture)
                    + " PONTOS";
            }

        }


    }
}
