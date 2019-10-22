using System;
using System.Collections.Generic;
using System.Text;

namespace ManipuladorDeDocumentos
{
    public class AnaliseString
    {
        public string Equipamento { get; set; }
        public int IgnLigada { get; set; }
        public int IgnDesligada { get; set; }
        public int EntSensor { get; set; }
        public bool UmEquip { get; set; }


        public AnaliseString(List<string> trans)
        {
            foreach (var item in trans)
            {
                string[] entrada = item.Split('/');

                if (Equipamento == null)
                {
                    Equipamento = entrada[0];
                    Contador(entrada[1]);
                    UmEquip = true;
                }
                else if (entrada[0] == Equipamento)
                {
                    Contador(entrada[1]);
                    UmEquip = true;
                }

                else if (entrada[0] != Equipamento)
                {
                    if (UmEquip == true) MostrarAnaliseString();
                    UmEquip = false;
                    Equipamento = entrada[0];
                    ZerarAtrib();
                    Contador(entrada[1]);
                }
                else Console.WriteLine("Erro ao analisar");
            }
            if (UmEquip == true) MostrarAnaliseString();
        }
        public void Contador(string x)
        {
            if (x == "100000") IgnLigada++;

            else if (x == "000000") IgnDesligada++;

            else if (x != "000000" && x != "100000") EntSensor++;
        }
        public void MostrarAnaliseString()
        {
            Console.WriteLine($"Equipamento: {Equipamento}, Ligado: {IgnLigada}, Desligada: {IgnDesligada}, EntradaSensor: {EntSensor}.");
        }
        void ZerarAtrib()
        {
            IgnDesligada = 0;
            IgnLigada = 0;
            EntSensor = 0;
        }
    }
}
