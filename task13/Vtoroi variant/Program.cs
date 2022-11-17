// Второй вариант

Console.Write("Второй вариант, Введите число с тремя и более цифрами ");


string? chislo = Console.ReadLine();

int i=Convert.ToInt32(chislo); // проверка число ли это
i= chislo.Length;
if ( i > 2 )
{
   Console.WriteLine ("третья цифра: "+ chislo[2]);


}
else
{
    System.Console.WriteLine("третей цифры нет");
}
