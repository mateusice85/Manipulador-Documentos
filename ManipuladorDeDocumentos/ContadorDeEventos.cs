using DocumentFormat.OpenXml.Office2010.ExcelAc;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManipuladorDeDocumentos
{
    public class ContadorDeEventos
    {
        private string Nome { get; set; }
        private int Porta1 { get; set; }
        private int Porta2 { get; set; }
        private int Porta3 { get; set; }
        private int Porta4 { get; set; }
        private int Porta5 { get; set; }
        private int Porta6 { get; set; }

        public List<string> ContarEventos(List<EntradasModulo> portasModulo)
        {
            List<string> ListaEquipamentos = new List<string>();

            foreach (var item in portasModulo)
            {
                if (Nome == default) Nome = item.Nome;
                if (Nome != item.Nome)
                {
                    InListaEquip();
                    ZerarProps();
                }
                Nome = item.Nome;
                Porta1 += int.Parse(item.Entrada_1);
                Porta2 += int.Parse(item.Entrada_2);
                Porta3 += int.Parse(item.Entrada_3);
                Porta4 += int.Parse(item.Entrada_4);
                Porta5 += int.Parse(item.Entrada_5);
                Porta6 += int.Parse(item.Entrada_6);
            }
            if (portasModulo.Count == 1) InListaEquip();

            return ListaEquipamentos;

            void InListaEquip()
            {
                ListaEquipamentos.Add($"{Nome} = Entrada1: {Porta1}, " +
                            $"Entrada2: {Porta2}, " +
                            $"Entrada3: {Porta3}, " +
                            $"Entrada4: {Porta4}, " +
                            $"Entrada5: {Porta5}, " +
                            $"Entrada6: {Porta6} ");
            }
        }
        private void ZerarProps()
        {
            Porta1 = 0;
            Porta2 = 0;
            Porta3 = 0;
            Porta4 = 0;
            Porta5 = 0;
            Porta6 = 0;
        }
        
    }
}
