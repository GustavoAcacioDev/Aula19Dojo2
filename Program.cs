using System;

namespace Aula19Dojo2
{
    class Program
    {
        static void Main(string[] args)
        {
            IngressoVIP ingresso = new IngressoVIP();
            ingresso.valor = 13f;
            ingresso.valorAdicional = 10f;

            ingresso.ImprimirValor();
            ingresso.ImprimirValorVIP();
        }
    }
}
