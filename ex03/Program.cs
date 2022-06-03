// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("введите десятичное положительное число: ");
int a = int.Parse(Console.ReadLine());

//метод перевода
void BinNum(int num)
{
    string binnum = "";
    int decnum = num;
    while (num > 0)
    {
        string text = (num % 2).ToString();
        num = num / 2;
        binnum = text + binnum;
    }
    Console.WriteLine($"Число {decnum} в двоичном формате равно: {binnum}");
}
//метод перевода

BinNum(a);
