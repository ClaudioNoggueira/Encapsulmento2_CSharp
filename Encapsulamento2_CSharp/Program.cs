using System;
using System.Globalization;

namespace Encapsulamento2_CSharp {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre com os dados do produto");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            float preco = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto produto = new Produto(nome, preco, quantidade);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + produto);
            Console.WriteLine();

            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            int qtde = int.Parse(Console.ReadLine());
            produto.adicionarProdutos(qtde);

            Console.WriteLine("Produtos atualizados: " + produto);

            Console.WriteLine();

            Console.WriteLine("Digite o número de produtos a ser removida do estoque: ");
            qtde = int.Parse(Console.ReadLine());
            produto.removerProdutos(qtde);

            Console.WriteLine("Produtos atualizados: " + produto);
        }
    }
}
