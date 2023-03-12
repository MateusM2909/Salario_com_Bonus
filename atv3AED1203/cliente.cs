using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv3AED1203
{
    internal class cliente
    {
        private string nome;
        private double salarioFixo;
        private double vendas;

        public string Nome
        {
            get{return nome;}
            set{nome = value;}
        }
        public double SalarioFixo
        {
            get { return salarioFixo;}
            set { salarioFixo = value;}
        }
        public double Vendas
        {
            get { return vendas;}
            set { vendas = value;}
        }

        public void ImprimirDados()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Salario Fixo: " + salarioFixo.ToString("F2"));
            Console.WriteLine("Montante de vendas: " + vendas);
            Console.WriteLine();
            Console.WriteLine();
        }

        public void total()
        {
            double x = (vendas * 0.15) + salarioFixo;
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Salario Final: " + x.ToString("F2"));
        }

    }
}
