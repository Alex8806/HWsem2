// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.Write("Введите трехзначное число ");


int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int i=5;
while ((number < 100 || number >999) && i>0)
    {System.Console.WriteLine($"вы ввели не трёхзначное число, число попыток {i}");

        System.Console.Write("Введите трехзначное число ");
        number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
        i--;}

if (number < 100 || number >999){System.Console.WriteLine("вы ввели не трёхзначное число");}


else{
    int a = number % 10;

    number -= a;

    System.Console.Write("вторая цифра: " + (number % 100) / 10);}
