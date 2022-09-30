using System.Globalization;

namespace Encapsulamento
{
    class Produto
    {
        // Esses atributos não podem ser acessados por outra classe.
        // Quando se trabalha com atributos privados, não se utiliza CamelCase por padrão
        // Se utiliza o _letraminuscula.
        private string _nome;
        public double Preco { get; private set;}
        public int Quantidade { get; private set; }

        public Produto() { }


        public Produto(string nome, double preco, int quantidade)
        {

            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;

        }
        // Propetie do Nome
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                    _nome = value;
            }
        }
        // Métodos

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
            Quantidade += quantidade;
        }


        // ToString()
        public override string ToString()
        {
            return $"{_nome} , $ {Preco}, {Quantidade} unidades, Total: $ {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
