using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Entidades
{
    internal class Contrato
    {
        public int Numero { get; set; }
        public string Contratante { get; set; }
        public double Valor { get; set; }
        public int Prazo { get; set; }

        public Contrato()
        {
        }

        public Contrato(int numero, string contratante, double valor, int prazo)
        {
            Numero = numero;
            Contratante = contratante;
            Valor = valor;
            Prazo = prazo;
        }

        public virtual double CalcularPrestacao()
        {
            return this.Valor / this.Prazo;
        }

        public virtual string ExibirInfo()
        {
            return "";
        }
    }
}
