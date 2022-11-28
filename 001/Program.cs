// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Write("Введите пятизначное число :" );
int num = Convert.ToInt32(Console.ReadLine());
string numRes=Convert.ToString(num);

    if (numRes[0] == numRes[4] && numRes[1] == numRes[3])
    {
        Console.WriteLine($"{num} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{num} - Не палиндром");
    }