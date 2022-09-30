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
        // Propetie do Nome , Preco e Quantidade
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                    _nome = value;
            }
        }

        public double Preco
        {
            get { return _preco; }
        }

        public int Quantidade
        {
            get { return _quantidade; }
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
