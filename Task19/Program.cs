// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

void Numbers(int number)

{
    int num1 = number % 10;
    int num2 = number / 10 % 10;
    int num4 = number / 1000 % 10;
    int num5 = number / 10000 % 10;
    if (num1 == num5)
    {
        if (num2 == num4)
        {
            Console.WriteLine("Число является полиндромом");
        }
        else Console.WriteLine("Число не является полиндромом!");
    }
    else Console.WriteLine("Число не является полиндромом!");
}
Numbers(number);