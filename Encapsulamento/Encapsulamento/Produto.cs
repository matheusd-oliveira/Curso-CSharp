using System.Globalization;

namespace Encapsulamento
{
    class Produto
    {
        // Esses atributos não podem ser acessados por outra classe.
        // Quando se trabalha com atributos privados, não se utiliza CamelCase por padrão
        // Se utiliza o _letraminuscula.
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto() { }


        public Produto(string nome, double preco, int quantidade)
        {

            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;

        }


        // Utilizando o Get para obter os atributos privados.
        public string GetNome()
        {
            return _nome;
        }


        public double GetPreco()
        {
            return _preco;
        }


        public int GetQuantidade()
        {
            return _quantidade;
        }


        // Utilizando o Set para setar atributos novos.
        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
                _nome = nome;
        }


        // Métodos

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }


        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }


        public void RemoverProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }


        // ToString()
        public override string ToString()
        {
            return $"{_nome} , $ {_preco}, {_quantidade} unidades, Total: $ {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
