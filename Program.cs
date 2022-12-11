// Программа, которая принимает на вход пятизначное число и проверяет, является ли оно полиндромом 
// (симметричным числом)
System.Console.WriteLine("Введите пятизначное число");
int Numb = Convert.ToInt32(Console.ReadLine());
if (Numb>=100000 || Numb<10000) System.Console.WriteLine("Это не пятизначное число");
else
{
    int firstNumb = Numb/10000;
    int secondNumb = Numb/1000%10;
    int fourthNumb = Numb%100/10;
    int fifthNumb = Numb%100%10;
    if (firstNumb==fifthNumb || secondNumb==fourthNumb) System.Console.WriteLine("да");
    else System.Console.WriteLine("нет");
}