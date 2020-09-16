using System.Globalization;
namespace Course
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        /*SOBRECARGA SE TRATA DA CRIAÇÃO DE VÁRIOS CONSTRUTORES PARA ATENDER
         * DIFERENTES SITUAÇÕES CONFORME MOSTRADO ABAIXO*/
        public Produto() // Construtor PADRAO vazio sem necessitar da entrada de parâmetros.
        {

        }

        public Produto(string nome, double preco, int qtd) //CONSTRUTOR PARA QUE SEJA OBRIGATÓRIO A ENTRADA DE DADOS(argumentos) PARA CRIAR UMA VARIÁVEL DA CLASSE PRODUTO.
        {
            Nome = nome;
            Preco = preco;
            Quantidade = qtd;
        }

        public Produto(string nome, double preco) //CONSTRUTOR COM 2 ARGUMENTOS (PARÂMETROS)
        {
            Nome = nome;
            Preco = preco;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}