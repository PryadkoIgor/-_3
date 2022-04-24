/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

using System;
using static System.Console;

WriteLine("Введите 5-тизначное число");
int x = int.Parse(ReadLine());
string poli = x.ToString();

if (poli[0] == poli[4] && poli[1] == poli[3]) 
{
    WriteLine("Число - полиндом");
}
else WriteLine("Не полиндром");