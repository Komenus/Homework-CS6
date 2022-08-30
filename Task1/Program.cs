// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Clear();
Console.WriteLine("Введите длинну массива ");
int M = int.Parse(Console.ReadLine());
int count = 0;
for(int i = 0; i < M; i++)
{
Console.WriteLine("Введите число  ");
int N = int.Parse(Console.ReadLine());
if(N >0)
{
    count++;
}
}
Console.WriteLine($"Вы ввели положительных чисел - {count} ");