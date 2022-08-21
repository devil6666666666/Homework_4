// Задаёт массив из 8 элементов и выводит их на экран

int[] arr = new int[8];
for (int i = 0; i < 8; i++)
{
    Console.Write($"Введите {i + 1}-й элемент массива:  ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine('[' + string.Join(", ", arr) + ']');

