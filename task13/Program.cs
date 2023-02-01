// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
int num = new Random().Next(1, 100000);
//int num = 32679; 
//Console.WriteLine(num); // 8,9 Для "быстрого теста"
int temp = num;
if (num / 100 == 0)
{
    Console.Write("Третьей цифры нет:(");
}
else
{
    while (temp >= 999)
    {
        temp = temp / 10;
    }
    Console.WriteLine($"{num} -> {temp % 10}");
}

