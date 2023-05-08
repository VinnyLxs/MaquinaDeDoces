using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //coletar dados
            Console.WriteLine("Informe um codigo:");
            int codigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o nome do produto");
            string nome = console.ReadLine();

            Console.WriteLine("Faça uma breve descrição do produto");
            string descricao = console.ReadLine();

            Console.WriteLine("Informe o preço do produto");
            string preco = Convert.ToDouble (console.ReadLine());

            Console.WriteLine("Informe a quantidade de produtos em estoque");
            string quantidade = Convert.ToInt32 (console.ReadLine());

            Console.WriteLine("Informe a data de validade do lote do produto");
            DateTime data = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Informe a situação: true - ativo | false - inativo");
            Boolean situacao = Convert.ToBoolean(Console.ReadLine());
            
            
            
            
            
            
            //instanciar a classe produto

            Produto prod = new Produto(codigo, nome, descricao, preco, quantidade, data, situacao);
            
            






            Console.ReadLine();//manter a janela aberta
        }//fim do metodo main
    }//fim do metodo classe
}//fim do projeto

