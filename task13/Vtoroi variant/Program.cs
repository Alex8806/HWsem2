// Второй вариант

Console.Write("Второй вариант, Введите число с тремя и более цифрами ");


string? chislo = Console.ReadLine();

int i=Convert.ToInt32(chislo); // проверка число ли это
i= chislo.Length;

if ( i > 2 && chislo[0] != '-' )
{
   Console.WriteLine ("третья цифра: "+ chislo[2]);


}
else if (i>3 && chislo[0]=='-')
{
    Console.WriteLine ("третья цифра: "+ chislo[3]);
}
else
{
    System.Console.WriteLine("третей цифры нет");
}
