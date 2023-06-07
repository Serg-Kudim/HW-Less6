// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


int InputNumber()
{
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
long SizeArray(long size)
{
    long count = 0;
    while (size > 0)
    {
        size /= 10;
        count++;
    }
    return count;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
void CreateArray(int[] arr, int num)
{
    for (int i = arr.Length - 1; i >= 0; i--)
    {
        arr[i] = num % 10;
        num /= 10;
    }
}
int SearchToNull(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == 0)
        {
            count++;
        }
    }
    return count;
}
Console.Write("Enter number: ");
int num = InputNumber();
int[] arrayNum = new int[SizeArray(num)];
CreateArray(arrayNum, num);
PrintArray(arrayNum); 
Console.WriteLine($"Zero - {SearchToNull(arrayNum)} pcs ");
