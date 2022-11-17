// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.Write("Введите день недели от 1 до 7: ");

int number = Convert.ToInt32(Console.ReadLine());

switch (number){
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
    System.Console.Write("Всем работать! Еще не выходной!");
    break;
    case 6:
    case 7:
    System.Console.Write("Ура! Выходной!");
    break;
    default:
    System.Console.Write("НЕТ ТАКОГО ДНЯ!!!!");
    break;
}
