while (true)
{
    Console.WriteLine("Введите сумму:");
    double sum = double.Parse(Console.ReadLine());
    Console.WriteLine("Виберите количества месяца:");
    int monthcount = int.Parse(Console.ReadLine());
    double sumbefore = sum;
    int i = 1;
    while (i <= monthcount)
    {

        double porsent = sum * 0.07;
        sum += porsent;
        Console.WriteLine($"{i} месяц-{sum}");
        i++;
    }
    double pribil = sum - sumbefore;
    Console.WriteLine($"Ваш прибыл {pribil}");


}