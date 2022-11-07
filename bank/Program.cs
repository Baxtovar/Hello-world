Console.WriteLine("Введите сумму:");
double sum = double.Parse(Console.ReadLine());
Console.WriteLine("Виберите количества месяца:");
int monthcount = int.Parse(Console.ReadLine());
double sumbefore = sum;
for (int i = 1; i <= monthcount; i++)
{
    double porsent = sum * 0.07;
    sum += porsent;
    Console.WriteLine($"{i} месяц-{sum}");

}
double pribil = sum - sumbefore;
Console.WriteLine($"Ваш прибыл {pribil}");
