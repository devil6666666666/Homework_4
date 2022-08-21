// Принимает на вход два числа (A и B) и возводит
// число A в натуральную степень B (через цикл)

Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
int C = 1;
for (int i = 1; i <= B; i++)
{
    C = C * A;
}
Console.WriteLine($"A в степени B = {C}");
