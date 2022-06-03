// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.Write("введите длину 1-ое число: ");
int a1 = int.Parse(Console.ReadLine());
Console.Write("введите длину 2-ое число: ");
int a2 = int.Parse(Console.ReadLine());
Console.Write("введите длину 3-е число: ");
int a3 = int.Parse(Console.ReadLine());

bool answer = false;

if (a1 + a2 > a3 & a2 + a3 > a1 & a3 + a1 > a2) answer = true;
//else answer=false;
Console.WriteLine(answer);
