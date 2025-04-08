
using consecionaria;
using System.Security.AccessControl;

Caminhão caminhao = new Caminhão("Mercedes MB 1113", "Mercedes", 1970, 100.00);
Carro carro = new Carro ("Corolla", "Toyta", 2012, 120.00);
Moto moto = new Moto("XT 660","Yamara", 2014, 150.00);

int ops = 1;

while (ops != 0)
{
    Console.WriteLine("================================LOCADORA===============================\n");
    Console.WriteLine("1 - Ver veiculos");
    Console.WriteLine("2 - Escolher carros");


    ops = int.Parse(Console.ReadLine());

    switch (ops)
    {
        case 1:
            caminhao.MostrarVeiculos();
            carro.MostrarVeiculos();
            moto.MostrarVeiculos();

            break;

        case 2:

            Console.WriteLine("1 - Caminhão");
            Console.WriteLine("2 - Carro");
            Console.WriteLine("3 - Moto");
            Console.WriteLine("Qual gostaria de alugar");

            int qualAlugar = int.Parse(Console.ReadLine());

            switch (qualAlugar)
            {
                case 1:
                    Console.WriteLine($"Voçê quer alugar esse caminhão, por quantos dias");
                    int dias = int.Parse(Console.ReadLine());
                    Console.WriteLine(carro.aluguel);
                    break;

            }
    }
}

