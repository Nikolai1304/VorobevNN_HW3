// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Введите любое пятизначное число");
int num = int.Parse(Console.ReadLine());


if (num/10000 ==num%10 && (num/1000)%10 == (num%100)/10)
{
    Console.WriteLine("Введенное число - палиндром");
}
else if (num/10000 >9 || num/10000 < 1)
{
    Console.WriteLine("Введенное число не соответствует условию задачи");
} 
else
{
    Console.WriteLine("Это не палиндром");
}

// Задача 21: Напишите программу, которая принимает 
// на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Write("Enter number X1   ");
int numx1 = int.Parse(Console.ReadLine());

Console.Write("Enter number Y1  ");
int numy1 = int.Parse(Console.ReadLine());

Console.Write("Enter number Z1  ");
int numz1 = int.Parse(Console.ReadLine());

Console.Write("Enter number X2   ");
int numx2 = int.Parse(Console.ReadLine());

Console.Write("Enter number Y2  ");
int numy2 = int.Parse(Console.ReadLine());

Console.Write("Enter number Z2  ");
int numz2 = int.Parse(Console.ReadLine());

Console.Write (Math.Sqrt(Math.Pow((numx1-numx2),2)+Math.Pow((numy1-numy2),2)+ Math.Pow((numz1-numz2),2)));

// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9. 
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число N  ");

int numN = int.Parse(Console.ReadLine());

int SqrN = 1;

while(SqrN <= numN)
{
    Console.WriteLine(Math.Pow(SqrN,3)+"  "); 
    SqrN++;
}



