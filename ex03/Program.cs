// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("введите десятичное положительное число: ");
int a = int.Parse(Console.ReadLine());

//метод перевода 1
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
//метод перевода 1

//BinNum(a);


//способ перевода 2
Console.Write("введите основание системы счисления: ");
int baseNum = int.Parse(Console.ReadLine());
// int d10 = 1;
// long result = 0;
// while (a != 0)
// {
//     result = result + a % baseNum * d10;
//     a /= baseNum; //a=a/2 тоже самое  a /= 2
//     d10 = d10 * 10;
// }
// Console.WriteLine(result);
//способ перевода 2



//способ перевода 3
void DecToOther (int num, int baseN)
{
    if (num==0)
    return;
    DecToOther (num/baseN, baseN);
    Console.Write(num%baseN);
}

DecToOther(a,baseNum);
//способ перевода 3