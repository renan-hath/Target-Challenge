using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetChallenge.Desafio03
{
    public class FaturamentoAnual
    {
        public double[] FaturamentosDiarios { get; set; }
        public double MenorFaturamentoDiario { get; set; }
        public double MaiorFaturamentoDiario { get; set; }
        public double MediaFaturamentoAnual { get; set; }
        public int DiasFaturamentoElevado { get; set; }

        public FaturamentoAnual(double[] faturamentosDiarios)
        {
            var faturamentosDiariosValidos = faturamentosDiarios.Where(x => x > 0).ToArray();

            this.FaturamentosDiarios = faturamentosDiarios;
            this.MenorFaturamentoDiario = this.FaturamentosDiarios.Min();
            this.MaiorFaturamentoDiario = this.FaturamentosDiarios.Max();
            this.MediaFaturamentoAnual = faturamentosDiariosValidos.Average();
            this.DiasFaturamentoElevado = this.FaturamentosDiarios.Count(x => x > this.MediaFaturamentoAnual);
        }
    }
}