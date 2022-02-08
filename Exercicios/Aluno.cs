using System;
using System.Globalization;

namespace Exercicios
{
    public class Aluno
    {
        public string Nome { get; set; }

        public double N1 { get; set; }

        public double N2 { get; set; }

        public double N3 { get; set; }

        public double CalculaNota() => N1 + N2 + N3;

        private static double CalcularNotaQueFaltou(double notaFinal) => notaFinal -= 60.0;

        public override string ToString()
        {
            var notaFinal = CalculaNota();

            if (notaFinal >= 60.0)
            {
                return "NOTA FINAL = " +
                        CalculaNota().ToString("F2", CultureInfo.InvariantCulture) + "\n" +
                       "APROVADO";
            }
            else if (notaFinal < 60)
            {
                var nota = CalcularNotaQueFaltou(notaFinal);
                return "NOTA FINAL = " +
                       CalculaNota().ToString("F2", CultureInfo.InvariantCulture) + "\n" +
                       "REPROVADO" + "\n" +
                       "FALTARAM " + Math.Abs(nota).ToString("F2", CultureInfo.InvariantCulture) + " PONTOS";
            }

            return null;

        }
    }
}
