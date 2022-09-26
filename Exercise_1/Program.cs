/* Программа, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

// (!) ВАРИАНТ 1

/* Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);

int num1 = number / 10000;
int num2 = (number / 1000) % 10;
int num3 = (number / 100) % 10;
int num4 = (number / 10) % 10;
int num5 = number % 10;

if ((number >= 10000) && (number < 100000))
{
    if ((num1 == num5) && (num2 == num4))
    {
        Console.WriteLine($"Заданное число {number} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Заданное число {number} НЕ является палиндромом");
    } 

}
else
{
    Console.WriteLine("Вы ввели не пятизначное число, повторите ввод!");
}*/ 


// (!) ВАРИАНТ 2

Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine()!;

int length = number.Length;

if (length == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"Заданное число {number} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Заданное число {number} НЕ является палиндромом");
    }
}
else
{
    Console.WriteLine("Вы ввели не пятизначное число, повторите ввод!");
}