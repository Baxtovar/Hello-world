Console.WriteLine("Виберите задачу");
int tasknumber = Convert.ToInt32(Console.ReadLine());
if (tasknumber == 1)
{
    Console.WriteLine("Введите ваше имя:");
    string name = Console.ReadLine();
    Console.WriteLine(name);
    Console.WriteLine("Сколько вам лет?");
    string name2 = Console.ReadLine();
    Console.WriteLine("Добрый день,Добро пожаловать " + name + " вам " + name2);
    Console.ReadLine();
}
else if (tasknumber == 2)
{
    Console.WriteLine("Какого года рождения?");
    int year = Convert.ToInt32(Console.ReadLine());
    int age = 2022 - year;

    Console.WriteLine($"Вам {age} лет!");
}
else if(tasknumber == 3)
{
    Console.WriteLine("Вводите первое чосло?");
    double number = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Вводите второе чосло?");
    double number1 = Convert.ToDouble(Console.ReadLine());
    double amont = number + number1;

    Console.WriteLine($"Суммаы {amont}");
}



