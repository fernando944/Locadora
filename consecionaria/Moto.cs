using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consecionaria
{
    public class Moto : Veiculos, IVeiculo
    {
        public Moto(string modelo, string marca, int ano, double valorDiario) : base(modelo, marca, ano, valorDiario)
        {
            
        }


        public override double Aluguel(int dias)
        {
            return ValorDiario * dias * 0.9;
        }
    }
}
