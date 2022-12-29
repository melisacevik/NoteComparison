internal class Program
{
    private static void Main(string[] args)
    {
        int bs = 0, toplam = 0, ks = 0;
        for (int a2 = 0, b1; a2 < 4; a2++)
        {
            Console.WriteLine(a2 + 1 + ". notu giriniz: ");
            b1 = Convert.ToInt32(Console.ReadLine());
            if (b1 > 100 || b1 < 0)
            {
                Console.WriteLine(" Yanlış not girdin.Lütfen tekrar gir: ");
                a2--;
                continue;
            }
            if (a2 == 0)
            {
                bs = b1;
                ks = b1;
            }
            else
            {
                if (b1 > bs)
                    bs = b1;
                if (b1 < ks)
                    ks = b1;
            }
            toplam += b1;

        }
        Console.Write("En buyuk: {0} En kucuk: {1}\nOrtalama: " + toplam / 4, bs, ks);

        Console.ReadLine();




    }
}