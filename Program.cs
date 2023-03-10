using System.Threading;

namespace Cronometro;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {

        Console.Clear();
        Console.WriteLine("S = segundos => 10s = 10 segundos");
        Console.WriteLine("M = minuitos => 1m = 10 minutos");
        Console.WriteLine("0 = sair");
        Console.WriteLine("Quanto tempo deseja contar?");

        string data = Console.ReadLine().ToLower();
        char type = char.Parse(data.Substring(data.Length - 1, 1));
        int time = int.Parse(data.Substring(0, data.Length - 1));

        int multiplier = 1;

        if (type == 'm')
        {
            multiplier = 60;
        }
        if (time == 0)
        {
            System.Environment.Exit(0);
        }

        PreStart(time * multiplier);

    }
    static void PreStart(int time)
    {
        Console.Clear();
        Console.WriteLine("Ready?");
         Thread.Sleep(1000);
         Console.WriteLine("set...");
         Thread.Sleep(1000);
         Console.WriteLine("GO...");
         Thread.Sleep(2500);

         Start(time);


    }
    
        static void Start(int time)
    {

        int CurrentTime = 0;

        while (CurrentTime != time)
        {

            Console.Clear();
            CurrentTime++;
            Console.WriteLine(CurrentTime);
            Thread.Sleep(1000);

        }

        Console.Clear();
        Console.WriteLine("Cronometro finalizado");
        Thread.Sleep(2500);

    }
}
