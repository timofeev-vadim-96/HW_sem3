// Программа, которая принимает на вход пятизначное число и проверяет, является ли оно полиндромом 
// (симметричным числом)
System.Console.WriteLine("Введите координату x точки А");
int xa = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату y точки А");
int ya = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату z точки А");
int za = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату x точки B");
int xb = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату y точки B");
int yb = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату z точки B");
int zb = Convert.ToInt32(Console.ReadLine());
double distance = Math.Sqrt(Math.Pow(xb-xa,2)+Math.Pow(yb-ya,2)+Math.Pow(zb-za,2));
System.Console.WriteLine($"Расстояние между точками = {Math.Round(distance, 2)}");