using System;
using System.Text;
using ClosedXML.Excel;

namespace ManipuladorDeDocumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa iniciado");
            Console.WriteLine();

            try
            {
                Console.Write("Digite 1 para rodar: ");
                byte resposta = byte.Parse(Console.ReadLine());
                Console.WriteLine();

                if (resposta == 1)
                {
                    RecepcaoDeDados novaLista = new RecepcaoDeDados();
                    novaLista.BuscarNaBase();
                    AnaliseString analiseString = new AnaliseString(novaLista.ListaString);

                }
            }
            catch (Exception)
            {
                Console.WriteLine();
                Console.WriteLine("Opção Inválida");
            }

            Console.WriteLine();
            Console.WriteLine("Fim");
        }
    }
}




//try
//            {
//                Console.Write("Digite 0 para cadastrar ou 1 para mostrar tudo: ");
//                byte resposta = byte.Parse(Console.ReadLine());
//Console.WriteLine();

//                if (resposta == 0)
//                {
//                    Console.Write("Digite seu nome, telefone e e-mail: ");
//                    string[] vet = Console.ReadLine().Split(' ');

//Cadastro cadastroNovo = new Cadastro(vet[0], vet[1], vet[2]);
//Console.WriteLine();
//                    Console.WriteLine(cadastroNovo.Mensagem);

//                }
//                else if(resposta == 1)
//                {
//                    RecepcaoDeDados novaLista = new RecepcaoDeDados();
//novaLista.CarregarListaTransmissoes();
                    
                    
//                }
//            }

//ExcelConexao a = new ExcelConexao();
//a.EntradaPlanilha();
//a.GerarPlanilha();