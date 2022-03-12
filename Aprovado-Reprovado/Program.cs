using System;
using System.Collections.Generic;
using System.Globalization;
using static Aprovado_Reprovado.Produtos;

namespace List
{
    class Program
    {
        static void ItensLista(string resposta, List<Produto> listaProdutos)
        { 
            {
                for (int contador = 0; contador < listaProdutos.Count; contador++)
                {
                    Console.WriteLine(listaProdutos[contador].Nome + " --- R$" + listaProdutos[contador].Valor);
                    Console.WriteLine("Descrição --- " + listaProdutos[contador].Descricao + " ---Descrição");
                }
            }
        }

        public static void PegarMaiorProduto(List<Produto> produtos)
        {

            int maiorPreco = 0;

            //Variavel do tipo Produto, recebe novo produto()= vazio já que ainda não descobri quem é o mais caro.
            Produto maisCaro = new Produto();

            for (var i = 0; i < produtos.Count; i++)
            {
                if (maiorPreco < produtos[i].Valor)
                {
                    maiorPreco = produtos[i].Valor;
                    maisCaro = produtos[i];

                    //new Produto(produtos[i].Nome, produtos[i].Preco);
                }
            }

            Console.WriteLine("Nome do item mais caro: " + maisCaro.Nome + " Valor: " + maisCaro.Valor + "R$ Descrição: " + maisCaro.Descricao);
            Console.WriteLine("MAIOR PREÇO " + maiorPreco);
        }

        
        static void Main(string[] args)
        {
            

            string resposta = "c";
            List<Produto> listaProdutos = new List<Produto>();

            //Não precisa usar o BREAK, Já que ele sempre ira validar ao final do WHILE.
            while (resposta.ToLower().Trim() == "c")
            {

                Console.WriteLine("Digite o nome do produto:");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o preço do produto:");
                int valor = int.Parse(Console.ReadLine());
                Console.WriteLine("Descrição do produto: ");
                string descricao = Console.ReadLine();
                Produto produto2 = new Produto(valor, nome, descricao);
                listaProdutos.Add(produto2);
                Console.WriteLine(@"Deseja Continuar?
[s] Sair
[c] Continuar");
                resposta = Console.ReadLine();
            }
            //## Metodo criado no topo Programa
            PegarMaiorProduto(listaProdutos);
            ItensLista(resposta, listaProdutos);

        }
    }
}
