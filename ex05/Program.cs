// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

Console.WriteLine("программа копирования массива");

int[] GenArray() //метод рандомного заполнения массива
{
    Console.Write("Введите число элементов массива: ");
    int n = int.Parse(Console.ReadLine());
    int[] arr = new int[n];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(100);//тут выбирается максимальное из 0 до введенного числа
    }
    return arr;
}

void PrintArray(int[] printArray) //метод печати массива
{
    var str = string.Join(" ", printArray);
    Console.WriteLine(str);
}


int[] CopyArray(int[] array) //метод копирования массива
{
    int[] copyArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copyArray[i] = array[i];
    }
    return copyArray;
}

int[] arr = GenArray();
PrintArray(arr);
int[] newarr = CopyArray(arr);
PrintArray(newarr);