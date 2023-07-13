﻿

int Input (string text)                  //Создаем метод, который считывает введенное значение с помощью Console.ReadLine и преобразует его в целое число.
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Task19()
{
    // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
    int number = Input("Введите пятизначное число:");
    string numberString = number.ToString(); // преобразуем число в строку, чтобы получить доступ к отдельным символам
    int length = numberString.Length; // задаем переменную, равную длинне введенной строке
    
    if( length == 5) // создаем условие для проверки является ли число пятизначным 
    {
        if(numberString[0]== numberString[4] && numberString[1]== numberString[3]) //сравниваем значения символа с индексом 0,4 (первая и последняя цифра) и с индексом 1,3 (вторая и четвертая цифра)
        {
            Console.WriteLine($"число {number} - является палиндромом");
        }
        else
        {
            Console.WriteLine($"число {number} - не является палиндромом"); 
        }
    }
    else
    {
        Console.WriteLine("Ошибка ввода");
    }
}

void Task21()
{
    // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
    int x1 = Input ("Введите значение точки x1:");
    int y1 = Input("Введите значение точки у1:");
    int z1 = Input("Введите значение точки z1:");
    int x2 = Input("Введите значение точки x2:");
    int y2 = Input("Введите значение точки у2:");
    int z2 = Input("Введите значение точки z2:");
    double distance = Math.Sqrt(Math.Pow(x1-x2,2)+ Math.Pow(y1-y2,2)+ Math.Pow(z1-z2,2)); // метод Math.Sqrt выносит значени из под корня; 
                                                                                            //метод Math.Pow(а,b) возводит число в степень (сначала указываем какое число возводим, затем в какую степень)
    Console.WriteLine($"Расстояние между точкой c координатой {x1}, {y1}, {z1} и точкой с координатой {x2}, {y2}, {z2}  = {Math.Round(distance,2)}");


}
void Task23()
{
    // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
    int n = Input("Введите число:");
    for(int i = 1; i <= n; i++)      
    {
        Console.WriteLine($"{i}^3 = {Math.Pow(i,3)}"); // метод Math.Pow(а,b) возводит число в степень (сначала указываем какое число возводим, затем в какую степень)
    }
}

int task = Input("Введите номер задачи:");
if(task ==19) Task19();
else if(task == 21) Task21();
else if(task == 23) Task23();