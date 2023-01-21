// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет
int InputInt(string message)
{
    Console.WriteLine(message + ">");
    string inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}
int dayofweek = InputInt("Введите цифру от 1 до 7 -");

if (dayofweek > 7 || dayofweek < 1)
{
    Console.WriteLine("Некорректное число");
}
else
{
    if (dayofweek == 6 || dayofweek == 7)
    {
        Console.WriteLine("Выходной день");
    }
    else
    {
        Console.WriteLine("Не является выходным днем");
    }
}