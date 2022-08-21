// Принимает на вход число и выдает сумму цифр в этом числе.
// Если введено отрицательное число, минус относится к первой цифре.

Console.WriteLine("Введите целое число: ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (Math.Abs(N) > 10)
{
    sum = sum + Math.Abs(N % 10);
    N = N / 10;
}
Console.WriteLine($"Сумма цифр в числе = {sum + N}");
