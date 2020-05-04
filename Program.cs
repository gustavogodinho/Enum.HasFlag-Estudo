using System;
using System.Runtime.InteropServices;

namespace flagsEstudo
{
    class Program
    {
        static void Main(string[] args)
        {
            var carro = new Carro
            {
                Marca = "AUDI",
                Modelo = "Q3 2.0 AMB",
                Ano = 2020,
                Preco = 2.000,
                Opcionais = Opcionais.KitLuxo
            };

            //HasFlag
            Console.WriteLine(carro.Opcionais.HasFlag(Opcionais.Alarme) == true ? "Meu Kit Opcional tem Alarme" : "Meu Kit Opcional não tem Alarme");

            Console.WriteLine(carro.ToString());

            //&
            var emcomum = Opcionais.TrioEletrico & Opcionais.SuperCompleto;
            Console.WriteLine($"Em Comum: {emcomum}");

            //^
            var diferenca = Opcionais.TrioEletrico ^ Opcionais.SuperCompleto;
            Console.WriteLine($"Em Comum: {diferenca}");


            Console.ReadLine();
        }


    }
    public class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public double Preco { get; set; }
        public Opcionais Opcionais { get; set; }

        public override string ToString()
        {
            return "Carro: " + Marca + " " + Modelo + " " + Ano + " " + Preco + " " + Opcionais;
        }
    }

    [Flags]
    public enum Opcionais
    {
        VidroEletrico = 1,
        TravaEletrica = 2,
        Alarme = 4,
        ArCondicionado = 8,
        DirecaoHidraulica = 16,
        ABS = 32,

        TrioEletrico = VidroEletrico | TravaEletrica | Alarme,
        KitLuxo = ArCondicionado | DirecaoHidraulica | ABS,
        SuperCompleto = TrioEletrico | KitLuxo
    }
}
