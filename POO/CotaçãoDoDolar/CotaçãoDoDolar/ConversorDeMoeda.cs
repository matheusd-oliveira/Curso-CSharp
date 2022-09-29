namespace CotaçãoDoDolar
{
    class ConversorDeMoeda
    {
        public static double Iof = 6.0;

        public static double DolarParaReal(double quantia, double cotacao)
        {
            double totalDeDolar = quantia * cotacao;
            double resultadoFinal = totalDeDolar + totalDeDolar * Iof / 100.0;

            return resultadoFinal;
        }
    }
}
