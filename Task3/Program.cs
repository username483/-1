﻿//Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Введите число ");
int A = int.Parse(Console.ReadLine());
if (A<=7)
{Console.WriteLine(A>=1 && A<=5 ? "нет" : "да");}
else {Console.WriteLine("число не соответствует задаче");}

