// Напишите программу, которая на вход принмает 3 трехзначных числа 
// и находит среднее арифметическое, далее проверяет больше ли 
// последняя цифра среднего арифметического, чем первая цифра минимума вводимых чисел.

// 111, 222, 333 - да
// 532, 164, 114 - нет
//551, 235, 631 - цифры равны

Console.Clear();
Console.WriteLine("Введите первое число ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int B = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число ");
int C = int.Parse(Console.ReadLine());


if (A>99 && A<999 && B>99 && B<999 && C>99 && C<999 )
{int average = (A+B+C)/3;
int lastnumAverage = average%10;

int min = A<B && A<C? A: B<A && B<C ? B: C;
int firstnumMin = min/100;

Console.WriteLine($"cреднее арифметическое = {average}");
Console.WriteLine($"минимальное трехзначное число = {min}");
Console.WriteLine(lastnumAverage==firstnumMin ? "числа равны" : lastnumAverage>firstnumMin ? "да" : "нет");}
else 
{
Console.WriteLine ("все числа должны быть трехзначными");

}
