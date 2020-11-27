using System;

namespace ListaPOOex9
{
    class Program
    {
        static void Main(string[] args)
        {
            Comparador comp;

            comp = new Comparador();

            Console.Write("Informe o primeiro valor ");
            comp.setValor1(int.Parse(Console.ReadLine()));

            Console.Write("Informe o segundo valor ");
            comp.setValor2(int.Parse(Console.ReadLine()));

            comp.CompararValores();

            Console.WriteLine("O maior valor é {0}", comp.getMaior());
        }
    }
}
