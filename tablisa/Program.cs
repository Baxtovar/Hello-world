//Console.WriteLine("таблица умножения");
//double number = 1;
//double number1 = 10;

//for (int i = 0; i <= 100; i++) 
//{
//    double sum = number * number1;
//  Console.WriteLine(sum); 
////}
//Console.WriteLine("\ny/x |   1\t2\t3\t4\t5\t6\t7\t8\t9");
//Console.Write("--------------------------------------------------------------------------");
//Console.WriteLine();
//for (int i = 1; i < 10; i++)
//{
//    Console.Write(i + "   |  ");
//    for (int j = 1; j < 10; j++)
//    {
//        Console.Write("\t" + i * j);
//    }
//    Console.WriteLine("");
//    Console.WriteLine("");
//}
//Console.ReadLine();

//for (int i = 1; i < 10; i++)
//{
//	for (int j = 1; j < 10; j++)
//	{
//		Console.WriteLine($"{i} * {j}={i * j}");
//	}
//}
int i = 1;

while (i < 10)
{
       
    int j = 1;
    
    while (j < 10)
    {
        Console.WriteLine($"{i}*{j} = {i * j}");

        j++;

    }
    i++;

}
