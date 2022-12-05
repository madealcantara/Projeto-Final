using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Entidades
{
    internal class ContratoPF : Contrato
    {
        public string CPF { get; set; }
        public int Idade { get; set; }

        public ContratoPF()
        {
        }

        public ContratoPF(int numero, string contratante, double valor, int prazo, string cPF, int idade) : base(numero, contratante, valor, prazo)
        {
            CPF = cPF;
            Idade = idade;
        }

        public override double CalcularPrestacao()
        {
            if (this.Idade <= 30)
            {
                return (Valor / Prazo) + 1;
            }
            else if (this.Idade <= 40)
            {
                return (Valor / Prazo) + 2;
            }
            else if (this.Idade <= 50)
            {
                return (Valor / Prazo) + 3;
            }
            else
            {
                return (Valor / Prazo) + 4;
            }
        }

        public override string ExibirInfo()
        {
            return ($"Valor do Contrato: R${(Valor).ToString("f2")} \n" +
                $"Prazo: {Prazo} meses \n" +
                $"Valor da Prestação: R${(CalcularPrestacao()).ToString("f2")} \n" +
                $"Idade: {this.Idade} anos");
        }
    }
}
    

