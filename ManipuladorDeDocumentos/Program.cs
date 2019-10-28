using System;
using System.Collections.Generic;
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
                ////testes
                //string a = "782193";
                //string b = "007601819";
                //Console.WriteLine(a.Length.ToString());
                //Console.WriteLine(b.Length.ToString());
                ////testes

                Console.Write("Digite 1 para rodar: ");
                byte resposta = byte.Parse(Console.ReadLine());
                Console.WriteLine();

                if (resposta == 1)
                {
                    RecepcaoDeDados novaLista = new RecepcaoDeDados();
                    ContadorDeEventos novoEvento = new ContadorDeEventos();

                    List<EntradasModulo> MostrarEvento = new List<EntradasModulo>();
                    List<string> MostrarContagem = new List<string>();

                    foreach (var item in novaLista.BuscarNaBase())
                    {
                        MostrarEvento.Add(item);
                    }
                    foreach (var item in novoEvento.ContarEventos(MostrarEvento))
                    {
                        MostrarContagem.Add(item);
                    }
                    
                    foreach (var item in MostrarContagem)
                    {
                        Console.WriteLine(item);
                    }

                }
            }
            catch (Exception ex)
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