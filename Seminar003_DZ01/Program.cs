// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
string txt = Convert.ToString(num);
int size = txt.ToString().Length;

if(size==5)
{
    if (txt[0]==txt[4]&&txt[1]==txt[3])
    {
        Console.WriteLine($"Число является зеркальным{txt}");
    }
    else
    {
        Console.WriteLine($"Число не является зеркальным{txt}");
    }
}
else
{
    Console.WriteLine($"Неверное значение{txt}");
}