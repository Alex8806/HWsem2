System.Console.Write("Введите число с тремя и более цифрами ");


int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

while (number < 100)
    {System.Console.WriteLine("вы ввели число менее чем с тремя цифрами");
        System.Console.Write("Введите число с тремя и более цифрами ");
        number = Math.Abs(Convert.ToInt32(Console.ReadLine()));}


    int a = number % 100;

    number -= a;

    System.Console.Write("третья цифра: " + (number % 1000) / 100);