using System.Globalization;

namespace Exercicios
{
    public class Funcionario
    {
        public string Nome { get; set; }

        public double Salario { get; set; }

        public double Imposto { get; set; }

        public double SalarioLiquido() => Salario -= Imposto;

        public double AumentarSalario(double porcentagem) => Salario += (Salario * porcentagem / 100.0);


        public override string ToString()
        {
            return Nome
            + ", R$ "
            + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}