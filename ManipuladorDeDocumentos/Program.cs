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
                Console.Write("Digite 1 e de enter para rodar: ");
                byte resposta = byte.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Nome do equipamento / Portas e quantidade de vezes em que ouve transmissão com valor na porta respectivos.");
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