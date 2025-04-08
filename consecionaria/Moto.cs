using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consecionaria
{
    internal class Moto : Veiculos, IVeiculo
    {
        public Moto (string Modelo, string Marca, int Ano, double ValorDiario) : base (Modelo, Marca, Ano, ValorDiario) { }
    }

}
