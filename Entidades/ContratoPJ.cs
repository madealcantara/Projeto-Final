using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Entidades
{
    internal class ContratoPJ : Contrato
    {
        public string CNPJ { get; set; }
        public string Inscricao { get; set; }

        public ContratoPJ()
        {
        }

        public ContratoPJ(int numero, string contratante, double valor, int prazo, string cNPJ, string inscricao) : base(numero, contratante, valor, prazo)
        {
            CNPJ = cNPJ;
            Inscricao = inscricao;
        }

        public override double CalcularPrestacao()
        {
            return (this.Valor / this.Prazo) + 3;
        }

        public override string ExibirInfo()
        {
            return ($"Valor do Contrato: R${(Valor).ToString("f2")} \n" +
                $"Prazo: {Prazo} meses \n" +
                $"Valor da Prestação: R${(CalcularPrestacao()).ToString("f2")}");
        }
    }
}
