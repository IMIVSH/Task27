// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();

Console.WriteLine("Введите ваше число: ");
int number = int.Parse(Console.ReadLine()!);

int numeralSum (int number)
{
    int sum = 0;
    while(number>0)
    {
        sum = sum + number % 10;
        number = number / 10 ;
    }
    return sum;
}

Console.WriteLine($"Сумма цифр в числе = {numeralSum (number)}.");