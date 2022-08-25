//Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Clear();
Console.WriteLine("Введите трехзначное число ");
int Anumber = int.Parse(Console.ReadLine());
string Atxt = Convert.ToString(Anumber);
if (Anumber>2)
{
    Console.WriteLine($"третья цифра " + Atxt[2]);
}
else 
{
    Console.WriteLine("третьей цифры нет");
}