using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consecionaria
{
    public class Carro : Veiculos, IVeiculo
    {
        public Carro(string Modelo, string Marca, int Ano, double ValorDiario) : base (Modelo, Marca, Ano, ValorDiario) 
        {
        }

    }
}
