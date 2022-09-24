using System;
using System.Globalization;

namespace ExercicioNotaDoAluno
{
    class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado()
        {
            if (NotaFinal() >= 60.0)
                return true;
            else
                return false;
        }

        public double NotaRestante()
        {
            if (Aprovado())
                return 0.0;
            else
                return 60 - NotaFinal();
        }




        // Exercicio comentado. O código foi refatorado de acordo com a correção
        // do exercicio do Professor. Porém, o código abaixo se encontra sem erros.
        /*public override string ToString()
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

        }*/

    }
}
