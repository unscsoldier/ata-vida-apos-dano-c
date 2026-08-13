using System;

class Program
{
    static void Main()
    {
        int vida = int.Parse(Console.ReadLine());
        int dano = int.Parse(Console.ReadLine());
        int restante = (vida < dano) ? 0 : vida - dano;

        Console.WriteLine(restante);
    }
}