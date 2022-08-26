// По двум заданным числам проверять является ли одно квадратом другого

Console.WriteLine ("Ведите число A");
int numberA = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine ("Ведите число B");
int numberB = int.Parse(Console.ReadLine() ?? "0");

if ( numberA == numberB * numberB)
{
   Console.WriteLine ("Число А это квадрат числа B"); 
}
else if (numberB == numberA * numberA)
{
   Console.WriteLine ("Число B это квадрат числа A"); 
}
else 
{
   Console.WriteLine ("Число А не является квадратом числа В и число В не является квадратом числа А"); 
}