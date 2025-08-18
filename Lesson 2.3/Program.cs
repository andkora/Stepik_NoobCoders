// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.ComponentModel.Design;
/*
char letter = Convert.ToChar(Console.ReadLine());
switch (letter)
{
    case 'а':
    case 'о':
    case 'у':
    case 'ы':
    case 'э':
    case 'я':
    case 'ё':
    case 'ю':
    case 'и':
    case 'е':
        Console.WriteLine("гласная");
        break;
    default:
        break;
}

/*Напишите программу, в который пользователь вводит цифру от 1 до 31. 
    То есть день месяца.  Учитывая что 1 число, это понедельник, программа должна выводить какой сегодня день недели. 
*/
/*
int dayNumber = Convert.ToInt32(Console.ReadLine());
int x = dayNumber % 7;
if (x == 1)
{
    switch (x)
    {
        case 1:
            Console.WriteLine("Понедельник");
            break;
    }
}
else if (x == 2)
{
    switch (x)
    {
        case 2:
            Console.WriteLine("Вторник");
            break;
    }
}
else if (x == 3)
{
    switch (x)
    {
        case 3:
            Console.WriteLine("Среда");
            break;
    }
}
else if (x == 4)
{
    switch (x)
    {
        case 4:
            Console.WriteLine("Четверг");
            break;
    }
}
else if (x == 5)
{
    switch (x)
    {
        case 5:
            Console.WriteLine("Пятница");
            break;
    } }
else if (x == 6)
{
    switch (x)
    {
        case 6:
            Console.WriteLine("Суббота");
            break;
    }
}
else if (x == 0)
{
    switch (x)
    {
        case 0:
            Console.WriteLine("Воскресенье");
            break;
    }
}

*/
//Напишите программу, которая выводит пользователю сообщение "Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение".
/*
Console.WriteLine("Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение");
int operation = Convert.ToInt32(Console.ReadLine());

switch (operation)
{
    case 1:
        Console.WriteLine("Сложение");
        break;
    case 2:
        Console.WriteLine("Вычитание");
        break;
    case 3:
        Console.WriteLine("Умножение");
        break;
    default:
        Console.WriteLine("Неизвестная операция!");
        break;
}

*/
/*
Console.WriteLine("Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение");

string line = Console.ReadLine();
string[] splitString = line.Split(' ');

int operation = Convert.ToInt32(splitString[0]);
double a = Convert.ToDouble(splitString[1]);
double b = Convert.ToDouble(splitString[2]);
double result = 0;

switch (operation)
{
    case 1:
        result = a + b;
        Console.WriteLine("Результат операции " + result);
        break;
    case 2:
        result = a - b;
        Console.WriteLine("Результат операции " + result);
        break;
    case 3:
        result = a * b;
        Console.WriteLine("Результат операции " + result);
        break;
    default:
        Console.WriteLine("Неизвестная операция!");
        break;
}
*/
/*
Сыграем в "камень - ножницы - бумага"?

В этой программе в консоль вводятся два числа, каждое с новой строки

Первое число (сверху) - выбор первого игрока, второе число (снизу) - выбор второго

0 - это камень

1 - это ножницы

2 - это бумага

Допишите программу, чтобы она выводила в консоль информацию о победителе одним из следующих вариантов:
*/
/*
string[] signs = { "камень", "ножницы", "бумага" };
Console.WriteLine("Выбирает первый игрок: 0 - камень, 1 - ножницы, 2 - бумага");
int input1 = int.Parse(Console.ReadLine());
Console.WriteLine($"Первый игрок выбрал: {signs[input1]}");
Console.WriteLine("Выбирает второй игрок: 0 - камень, 1 - ножницы, 2 - бумага");
int input2 = int.Parse(Console.ReadLine());
Console.WriteLine($"Второй игрок выбрал: {signs[input2]}");
if (((input1 == 0) && (input2 == 1)) || ((input1 == 1) && (input2 == 2)) || ((input1 == 2) && (input2 == 0)))
{
    input1 = 0;
    switch (input1)
    {
        case 0:
            Console.WriteLine("Результат: Победил первый игрок");
            break;
    }
}
else if (((input1 == 1) && (input2 == 0)) || ((input1 == 2) && (input2 == 1)) || ((input1 == 0) && (input2 == 2)))
{
    input1 = 0;
    switch (input1)
    {
        case 0:
            Console.WriteLine("Результат: Победил второй игрок");
            break;
    }
}
else if (((input1 == 0) && (input2 == 0)) || ((input1 == 1) && (input2 == 1)) || ((input1 == 2) && (input2 == 2)))
{
    Console.WriteLine("Результат: Ничья");
}

else
{

    Console.WriteLine("Неизвестная операция!");
}


string[] signs = { "камень", "ножницы", "бумага" };
Console.WriteLine("Выбирает первый игрок: 0 - камень, 1 - ножницы, 2 - бумага");
int input1 = int.Parse(Console.ReadLine());
Console.WriteLine($"Первый игрок выбрал: {signs[input1]}");
Console.WriteLine("Выбирает второй игрок: 0 - камень, 1 - ножницы, 2 - бумага");
int input2 = int.Parse(Console.ReadLine());
Console.WriteLine($"Второй игрок выбрал: {signs[input2]}");

switch (input1)
{
    case 0: //первый игрок выбрал камень
     switch (input2)
        {
            case 0: Console.WriteLine("Результат: Ничья");break;
            case 1: Console.WriteLine("Результат: Победил первый игрок");break;
            case 2: Console.WriteLine("Результат: Победил второй игрок");break;

        }
        break;
    case 1: //первый игрок выбрал ножницы
        switch (input2)
        {
            case 0: Console.WriteLine("Результат: Победил второй игрок"); break;
            case 1: Console.WriteLine("Результат: Ничья"); break;
            case 2: Console.WriteLine("Результат: Победил первый игрок"); break;

        }
        break;
    case 2: //первый игрок выбрал бумага
        switch (input2)
        {
            case 0: Console.WriteLine("Результат: Победил первый игрок"); break;
            case 1: Console.WriteLine("Результат: Победил второй игрок"); break;
            case 2: Console.WriteLine("Результат: Ничья"); break;

        }
        break;
}

Дополните код чтобы он мог определять чётное или нечётное число было введено и выводило соответсвующие строки:
"ODD" (нечётное) или "EVEN" (чётное).


int num = Int32.Parse(Console.ReadLine()); // Запрашиваем ввод из консоли и вытягиваем из него число

string answer = num % 2 == 0 ? "EVEN" : "ODD";

Console.WriteLine(answer);

*/

/*Напишите программу для изменения координат точки посредством введения пользователем текстовых команд в консоль. 
    Перемещение по оси y осуществляется командами вниз и вверх, а по оси x - командами влево и вправо.


using System;

public class MainClass
{
    public static void Main()
    {
        int x = 0;
        int y = 0;

        string arrow = Convert.ToString(Console.ReadLine());
        switch (arrow)
        {
            case "вверх": y = y++;break;
            case "вниз": y = y--; break;
            case "влево": x = x--; break;
            case "вправо": x = x++; break;
        }

    }
}
*/
/* 
 Проверка работоспособности и ыгрузки на гитхаб


Console.WriteLine("Hellow, Chuwi");
*/

/* И вновь дядя Вася берется за измерения, но на этот раз он решил измерить свой дачный участок своей старой рулеткой 5м, 
 пытаясь найти площадь. Участок имеет форму прямоугольника.

Напишите программу, которая вычисляет площадь участка.

Напоминаем, что у рулетки отломаны первые 20 см и дядя Вася об этом не знает (он напишет 1.2 м, хотя в реальности измерил 1 м). 
А так как длина рулетки меньше стороны участка, то дядя Вася каждый раз, когда заканчивается длина рулетки, 
ставит зарубку на ограде и,
переставляя рулетку, продолжает измерения от зарубки.
*/

Console.WriteLine("Введите два числа через пробел: длина и ширина участка");
string line = Console.ReadLine();
string[] splitString = line.Split(' ');

double length = Convert.ToDouble(splitString[0]); // длина
double width = Convert.ToDouble(splitString[1]); // ширина
double landArea = 0;                             // переменная для площади
double single = 4.8;
int CheckLenght = Convert.ToInt32(length % 5);
int Checkwidth = Convert.ToInt32(width % 5);
switch (CheckLenght)
{
    case 0:
        switch (Checkwidth)
        {
            case 0:
                length = length <= 5 ? (length - 0.2) : (single * Math.Floor(length / 5));
                width = width <= 5 ? (width - 0.2) : ((single * Math.Floor(width / 5))); break;
            default:
                length = length <= 5 ? (length - 0.2) : (single * Math.Floor(length / 5));
                width = width <= 5 ? (width - 0.2) : ((single * Math.Floor(width / 5)) + ((width % 5) - 0.2)); break;
        }
        break;
    default:
        switch (Checkwidth)
        {
            case 0:
                length = length <= 5 ? (length - 0.2) : ((single * Math.Floor(length / 5)) + ((length % 5) - 0.2));
                width = width <= 5 ? (width - 0.2) : ((single * Math.Floor(width / 5))); break;
            default:
                length = length <= 5 ? (length - 0.2) : ((single * Math.Floor(length / 5)) + ((length % 5) - 0.2));
                width = width <= 5 ? (width - 0.2) : ((single * Math.Floor(width / 5)) + ((width % 5) - 0.2)); break;
        }
        break;
}
landArea = Math.Round((length * width),2);
// 
Console.WriteLine($"Площадь участка: {landArea}");