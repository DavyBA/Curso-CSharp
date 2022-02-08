using System.Globalization;

namespace Segundo
{
    public class Produto
    {
        public string Nome { get; set; }

        public double Preco { get; set; }

        public int Quantidade { get; set; }

        public Produto()
        {
        }

        public Produto(string Nome, double preco, int quantidade)
        {
            this.Nome = Nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade) => Quantidade += quantidade;

        public void RemoverProdutos(int quantidade) => Quantidade -= quantidade;

        public override string ToString()
        {
            return Nome + ", $ " +
                   Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " +
                   Quantidade + " unidades, Total: $ " +
                   ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
