// Задача: Написать программу, которая из имеющегося массива строк
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

// Объявление переменных
string[] Array1;
string[] Array2;
string[] Array3;
string str;
int count = 0;
int j = 0;

// Ввод строковых значений в массив
Console.WriteLine();
Console.WriteLine("Введите несколько произвольных значений в массив.");
Console.WriteLine("Окончанием ввода значений служит ввод пустого значения - нажатие клавиши «Enter».");
Console.WriteLine();

Array1 = new string[count];
do
{
    Console.Write("Введите произвольное значение:");
    str = Console.ReadLine()!;
    if (str != "")
    {
        count++;
        Array2 = new string[count];
        for (int i = 0; i < Array2.Length - 1; i++) Array2[i] = Array1[i];
        Array2[count - 1] = str;
        Array1 = Array2;
    }
}
while (str != "");
Console.WriteLine();
Console.WriteLine("Ввод значений в массив завершён!");
Console.WriteLine();

// Вывод массива строк исходного массива Array1
for (int i = 0; i < Array1.Length; i++)
    if (i == 0)
    {
        Console.Write("[ “{1}”", i, Array1[i]);
    }
    else
    {
        Console.Write(", “{1}”", i, Array1[i]);
    }
Console.Write(" ]  →  [");

// Формирование и вывод массива Array3 с длиной элементов менее 3-х символов
for (int i = 0; i < Array1.Length; i++)
{
    if (Array1[i].Length <= 3)
    {
        Array3 = new string[j + 1];
        Array3[j] = Array1[i];
        if (j == 0)
        {
            Console.Write(" “{1}”", j, Array3[j]);
        }
        else
        {
            Console.Write(", “{1}”", j, Array3[j]);
        }
        j++;
    }
}
Console.WriteLine(" ]");
Console.WriteLine();