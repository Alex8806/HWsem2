// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


System.Console.Write("Введите число с тремя и более цифрами ");


int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if(number < 100)
{
System.Console.WriteLine("третей цифры нет");
}
   

else
{
    while (number>999){
        number /=10;
    }
    System.Console.WriteLine("третья цифра : " + (number%10));
}

