using System;
using System.Globalization;

namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio01();
            //Exercicio02();

            //ExercicioPropostos01();
            //ExercicioPropostos02();
            ExercicioPropostos03();
        }


        private static void Exercicio01()
        {
            var primeiraPessoa = new Pessoa();
            var segundaPessoa = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            primeiraPessoa.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            primeiraPessoa.Idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            segundaPessoa.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            segundaPessoa.Idade = Convert.ToInt32(Console.ReadLine());

            if (primeiraPessoa.Idade > segundaPessoa.Idade)
                Console.WriteLine("Pessoa mais velha: " + primeiraPessoa.Nome);
            else if (segundaPessoa.Idade > primeiraPessoa.Idade)
                Console.WriteLine("Pessoa mais velha: " + segundaPessoa.Nome);
            else
                Console.WriteLine("Tem a mesma idade: " + primeiraPessoa.Nome + " e " + segundaPessoa.Nome);
        }

        private static void Exercicio02()
        {
            var primeiroFuncionario = new Funcionario();
            var segundoFuncionario = new Funcionario();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            primeiroFuncionario.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            primeiroFuncionario.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            segundoFuncionario.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            segundoFuncionario.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var mediaSalario = (primeiroFuncionario.Salario + segundoFuncionario.Salario) / 2.0;
            Console.WriteLine("Salário médio: " + mediaSalario.ToString("F2", CultureInfo.InvariantCulture));
        }

        private static void ExercicioPropostos01()
        {
            var retangulo = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retângulo: ");
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            retangulo.Area();
            retangulo.Perimetro();
            retangulo.Diagonal();

            Console.WriteLine(retangulo.ToString());
        }

        private static void ExercicioPropostos02()
        {
            var funcionario = new Funcionario();
            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            funcionario.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            funcionario.SalarioLiquido();
            Console.WriteLine("Funcionário: " + funcionario);

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            var porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(porcentagem);

            Console.WriteLine();
            Console.Write("Dados atualizados: " + funcionario);
        }

        private static void ExercicioPropostos03()
        {
            var aluno = new Aluno();
            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            aluno.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write(aluno);
        }
    }
}
