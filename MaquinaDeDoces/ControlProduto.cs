using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MaquinaDeDoces
{
    class ControlProduto
    {
        Produto prod;
        private int opcao;
        public ControlProduto()
        {
            prod= new Produto();
            modificarOpcao = -1;
        }// fim do cosultor 

        // metodo getSet

        public int modificarOpcao
        {
            get { return opcao; }
            set { opcao = value; }
        }

        public void Menu()
        {
            Console.WriteLine("Escolha uma das opções abaixo:\n " +
                "0.Sair\n" +
                "1.Cadastrar Produto\n" +
                "2.Consultar Produto\n" +
                "3.Atualizar Produto\n" +
                "4.Mudas Situação\n");
            modificarOpcao = Convert.ToInt32(Console.ReadLine());

        }// Fim do metodo menu

        //realizar a operação 

        public void Operacao()
       
        {
            do
            { 
                    Menu();
                switch (modificarOpcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado");
                        Console.Clear(); //limpar console
                        break;
                    case 1:
                        ColetarDados();
                        Console.Clear(); //limpar console
                        break;
                    case 2:
                        Consultar();
                        Console.Clear(); //limpar console
                        break;
                    case 3:
                        atualizar();
                        Console.Clear(); //limpar console
                        break;
                    case 4:
                        AlterarSituacao();
                        break;
                    default:
                        Console.WriteLine("Opção escolhida não é valida");
                        break;
                }
            }while (modificarOpcao != 0);
        }





        //criar um metodod de solicitação de dados 
        public void ColetarDados()
        {         
            //coletar dados
            Console.WriteLine("Informe um codigo:");
            int codigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o nome do produto");
            string nome = (Console.ReadLine());

            Console.WriteLine("Faça uma breve descrição do produto");
            string descricao = (Console.ReadLine());

            Console.WriteLine("Informe o preço do produto");
            double preco = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de produtos em estoque");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a data de validade do lote do produto");
            DateTime data = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Informe a situação: true - ativo | false - inativo");
            Boolean situacao = Convert.ToBoolean(Console.ReadLine());
            
            //cadastrar produto
            prod.CadastrarProduto(codigo, nome, descricao, preco, quantidade, data);
            Console.WriteLine("Dado Registrado!");
        
        }//Fim do ColetarDados
        
        //consultar 
        public void Consultar()
        {
            Console.WriteLine("\n\n\nInforme o codigo do produto que deseja consultar");
            int codigo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Os dados do produto escolhido são:\n\n\n" + prod.ConsultarProduto(codigo));
        }
        public void atualizar()
        {
            Console.WriteLine("\n\nInforme o codigo do produto que deseja atualizar:");
            int codigo = Convert.ToInt32(Console.ReadLine());

            short campo = 0;


            do
            {
                Console.WriteLine("Informe o campo que deseja atualizar de acordo com a regra abaixo:\n" +
                    "1. Nome\n" +
                    "2. Descrição\n " +
                    "3. Preço\n" +
                    "4. Data de Validade\n" +
                    "5. Situação\n" +
                    "6. Quantidade");
                campo = Convert.ToInt16(Console.ReadLine());

                //avisar usuario
                if ((campo < 1) || (campo > 6))
                {
                    Console.WriteLine("Erro, escolha um codigo entre 1 e 6");
                }

            } while ((campo < 1) || (campo > 6));
            Console.WriteLine("Informe o dado para atualização");
            string novoDado = Console.ReadLine();
            
            //chamar o metodo de atualização
            prod.AtualizarProduto(codigo,campo,novoDado);
            Console.WriteLine("Atualizado!");
        
        
        }


        public void AlterarSituacao()
        {
            Console.WriteLine("Informe o codigo do produto que deseja alterar o status");
            int codigo = Convert.ToInt32(Console.ReadLine());

            //chamar o metodo alterarSituação - classe produto

            prod.AlterarSituacao(codigo);
            Console.WriteLine("Alterado");

        }//fim do metodo 

    }//Fim da classe
}//Fim do projeto
