using System;
using System.Collections.Generic;
using System.Text;
using ClosedXML.Excel;

namespace ManipuladorDeDocumentos
{
    //class ExcelConexao
    //{
    //    private string NomeDaPlanilha { get; set; }

    //    private int Linha = 0;

    //    private readonly List<string> Celula = new List<string>();

    //    public ExcelConexao()
    //    {
    //        Console.WriteLine("Digite o nome da planilha");
    //        string nome = Console.ReadLine();
    //        NomeDaPlanilha = nome;
    //    }


    //    public void EntradaPlanilha()
    //    {
    //        Console.WriteLine("Entre com a string");
    //        string[] vet = Console.ReadLine().Split('|');

    //        foreach (var item in vet)
    //        {
    //            Celula.Add(item);
    //        }
    //        Linha++;
            
    //    }
    //    public void GerarPlanilha()
    //    {
    //        var wb = new XLWorkbook();
    //        var PlanilhaDeTrabalho = wb.Worksheets.Add(NomeDaPlanilha);

    //        string az = "a b c d e f g h i j k l m n o p q r s t u v w x y z";
            
    //        string[] abc = az.ToUpper().Split(" ");
    //        int cont = 0;

    //        foreach (var item in Celula)
    //        {
    //            if (abc[cont] == "z")
    //            {
    //                PlanilhaDeTrabalho.Cell(abc[cont] + Linha.ToString()).Value = item;
    //                cont = 0;
    //            }
    //            else PlanilhaDeTrabalho.Cell(abc[cont] + Linha.ToString()).Value = item;
    //            cont++;
    //        }

    //        wb.SaveAs($"C:/Users/Mateus/Music/{NomeDaPlanilha}.xlsx");
    //        PlanilhaDeTrabalho.Delete();
    //        wb.Dispose();
    //        Console.WriteLine($"Planilha {NomeDaPlanilha} gerada com sucesso.");
    //    }

    //}
}
