// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void CubsNumbers(int number)
{
    int count = 1;
    while (count <= number)
    {
        int result = count * count * count;
        Console.Write(result + " ");
        count++;
    }
}
CubsNumbers(number);
