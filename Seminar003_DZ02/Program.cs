// Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите число AX = ");
int numAX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число AY = ");
int numAY = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число AZ = ");
int numAZ = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число BX = ");
int numBX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число BY = ");
int numBY = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число BZ = ");
int numBZ = Convert.ToInt32(Console.ReadLine());
double result =Math.Sqrt(Math.Pow((numAX-numBX),2)+Math.Pow((numAY-numBY),2)+Math.Pow((numAZ-numBZ),2));
Console.WriteLine($"Расстояние между двумя точками в 3D пространстве = {result}");