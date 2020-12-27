using System.Globalization;

namespace Encapsulamento2_CSharp {
    class Produto {
        private string nome;
        public float preco { get; set; }

        public int qtde { get; set; }
        public string Nome {
            get => nome;
            set {
                if (value != null) {

                }
            }
        }

        public Produto(string nome, float preco, int qtde) {
            this.nome = nome;
            this.preco = preco;
            this.qtde = qtde;
        }

        public float valorTotalEmEstoque() {
            return this.preco * this.qtde;
        }

        public void adicionarProdutos(int qtde) {
            this.qtde += qtde;
        }

        public void removerProdutos(int qtde) {
            this.qtde -= qtde;
        }

        public override string ToString() {
            return this.nome + ", R$ " + this.preco.ToString("F2", CultureInfo.InvariantCulture).Replace(".", ",")
         
                + ", " + this.qtde + " unidades, Total: R$ " + valorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture).Replace(".", ",");
        }
    }
}
