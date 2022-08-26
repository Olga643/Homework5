// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.WriteLine ("Ведите число от 1 до 7");
int number = int.Parse(Console.ReadLine() ?? "0");

if ( number > 5 )
{ 
    Console.WriteLine ("Ура! Выходной");
}    
else 
{
    Console.WriteLine ("Будний день");
}