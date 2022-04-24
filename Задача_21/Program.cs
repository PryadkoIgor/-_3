/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

using System;
using static System.Console;

double x1 = Convert.ToDouble(ReadLine());
double y1 = Convert.ToDouble(ReadLine());
double z1 = Convert.ToDouble(ReadLine());
double x2 = Convert.ToDouble(ReadLine());
double y2 = Convert.ToDouble(ReadLine());
double z2 = Convert.ToDouble(ReadLine());

double c = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
WriteLine(c);