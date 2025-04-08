using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consecionaria
{
    public class Veiculos : IVeiculo
    {
        public Veiculos(string modelo, string marca, int ano, double valorDiario)
        {
            Modelo = modelo;
            Marca = marca;
            Ano = ano;
            ValorDiario = valorDiario;
        }

        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int Ano { get; set; }
        public double ValorDiario { get; set; }
        public double aluguel(int dias)
        {
            return ValorDiario * dias;
        }

        public decimal Aluguel(int dias)
        {
            throw new NotImplementedException();
        }

        public void MostrarVeiculos()
        {
            Console.WriteLine($" Modelo = {Modelo}/Marca = {Marca}/ano = {Ano}/Valor diario é = {ValorDiario}");
        }
    }

}






