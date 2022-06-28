/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Вывод сделать отдельным методом.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
6, 1, 33 -> [6, 1, 33] */

int[] numbers = new int [8];

for(int i = 1; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(0, 1000);
}

Printer(numbers);

void Printer (int[] numbers)
{
    for(int i = 1; i < numbers.Length; i++)
    {
        Console.WriteLine(numbers[i]);
    }
}