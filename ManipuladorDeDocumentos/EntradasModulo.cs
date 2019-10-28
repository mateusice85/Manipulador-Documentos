using System;
using System.Collections.Generic;
using System.Text;

namespace ManipuladorDeDocumentos
{
    public class EntradasModulo
    {
        public string Nome { get; private set; }
        public string Entrada_1 { get; private set; }
        public string Entrada_2 { get; private set; }
        public string Entrada_3 { get; private set; }
        public string Entrada_4 { get; private set; }
        public string Entrada_5 { get; private set; }
        public string Entrada_6 { get; private set; }

        public EntradasModulo(string nome, char[] transEntr)
        {
            Nome = nome;
            Entrada_1 = transEntr[0].ToString();
            Entrada_2 = transEntr[1].ToString();
            Entrada_3 = transEntr[2].ToString();
            Entrada_4 = transEntr[3].ToString();
            Entrada_5 = transEntr[4].ToString();
            Entrada_6 = transEntr[5].ToString();
        }

         
        //public override string ToString()
        //{
        //    return $"Porta 1: {Entrada_1}, " +
        //        $"Porta 2: {Entrada_2}, " +
        //        $"Porta 3: {Entrada_3}, " +
        //        $"Porta 4: {Entrada_4}, " +
        //        $"Porta 5: {Entrada_5}, " +
        //        $"Porta 6: {Entrada_6} ";
        //}
    }
}
