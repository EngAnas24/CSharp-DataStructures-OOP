using System;

class Program
{
    static void Main()
    {
        int durum = 0;

        while (true)
        {
            switch (durum)
            {
                case 0:
                    durum = Durum0();
                    break;
                case 1:
                    durum = Durum1();
                    break;
                case 2:
                    durum = Durum2();
                    break;
                case 3:
                    durum = Durum3();
                    break;
                default:
                    Console.WriteLine("Program Sonlandi");
                    break;
            }

            if (durum == -1)
                break;
        }

        Console.ReadKey();
    }

    static int Durum0()
    {
        Console.WriteLine("Otomat Başladı");
        Console.WriteLine("A'dayım");
        char kr = Convert.ToChar(Console.ReadLine());

        if (kr == 'a' || kr == 'A')
            return 1;
        else
            return 0;
    }

    static int Durum1()
    {
        Console.WriteLine("Ş'dayım");
        char kr = Convert.ToChar(Console.ReadLine());

        if (kr == 'S' || kr == 's')
            return 2;
        else if (kr == 'a' || kr == 'A')
            return 1;
        else
            return 0;
    }

    static int Durum2()
    {
        Console.WriteLine("K'dayım");
        char kr = Convert.ToChar(Console.ReadLine());

        if (kr == 'k' || kr == 'K')
            return 3;
        else if (kr == 'a' || kr == 'A')
            return 2;
        else
            return 0;
    }

    static int Durum3()
    {
        Console.WriteLine("Program Bitti");
        Console.WriteLine("Aşk=Biçimsel Diller ve Otomata");
        return -1;
    }
}
