using System;
using System.Globalization;

namespace atv3AED1203
{
    internal class Program
    {

        static void Main(string[] args)
        {
            cliente c = new cliente();
            c.Nome = "Manoel Gomez";
            c.SalarioFixo = 500.00;
            c.Vendas = 1230.30;

            c.ImprimirDados();
            c.total();

        }
    }
}
