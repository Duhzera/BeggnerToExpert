using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprovado_Reprovado
{
    class Produtos
    {
        public class Produto { 
        
            public int Valor { get; set; }
            public string Nome { get; set; }

            public string Descricao { get; set; }

            public Produto(int valor, string nome, string descricao)
            {
                Valor = valor;
                Nome = nome;
                Descricao = descricao;
            }
            public Produto() { }
        }
    }
}
