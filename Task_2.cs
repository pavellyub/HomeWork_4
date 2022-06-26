/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());

int result = 0;
int advance = 0;
for(int i = 1; i < A; i++)
{
    advance = A % 10;
    result = result + advance;
    A = A / 10;
}

Console.WriteLine($"Ответ: {result}");