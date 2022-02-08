using System;
using System.Globalization;

namespace Exercicios
{
    public class Retangulo
    {
        public double Largura { get; set; }

        public double Altura { get; set; }

        public double Area() => Largura * Altura;

        public double Perimetro() => 2 * (Largura + Altura);

        public double Diagonal() => Math.Sqrt(Largura * Largura + Altura * Altura);

        public override string ToString()
        {
            return "AREA = " + Area().ToString("F2", CultureInfo.InvariantCulture) + "\n" +
                   "PERÍMENTRO = " + Perimetro().ToString("F2", CultureInfo.InvariantCulture) + "\n" +
                   "DIAGONAL = " + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
