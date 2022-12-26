using System;

namespace Lab.retry._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Baslangic ededi daxil edin:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Son reqemi daxil edin:");
            int b = int.Parse(Console.ReadLine());
            int count = 0;
            int sum = 0;
            for (int i =0; i <= b; i++)
            {
                sum += i;
                count++;
            }
            Console.WriteLine($"\n ededlerinin sayi: {count}\n Ededlerin cemi: {sum}");
        }
    }
}
