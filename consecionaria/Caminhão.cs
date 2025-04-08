using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consecionaria
{
    public class Caminhão : Veiculos, IVeiculo
    {
        public Caminhão(string Modelo, string Marca, int Ano, double ValorDiario) : base(Modelo, Marca, Ano, ValorDiario)
        {
            ValorDiario = ValorDiario;
        }


        public override double Aluguel(int dias)
        {
            return ValorDiario * dias * 1.2;
        }
    }
}
