// See https://aka.ms/new-console-template for more information

using System;
using System.ComponentModel.Design;
/*
int num = Int32.Parse(Console.ReadLine()); // Запрашиваем ввод из консоли и вытягиваем из него число

if ((num%2)==0) // Напишите свой код вместо "..." слева
{
    Console.WriteLine("EVEN");
}
else
{
    Console.WriteLine("ODD");
}
*/
//Напишите программу, в которую пользователь вводит с клавиатуры два числа. А программа сравнивает два введенных числа и выводит на консоль результат сравнения.
/*
string line = Console.ReadLine();
string[] splitString = line.Split(' ');

int a = Convert.ToInt32(splitString[0]);
int b = Convert.ToInt32(splitString[1]);

if (a==b)
{
    Console.WriteLine("a = b");
}
else if(a<b)
{
    Console.WriteLine("a < b");
}
else
{
    Console.WriteLine("a > b");
}
*/
//Напишите программу, в которой пользователь вводит с клавиатуры три числа.
//Программа должна вывести минимальное значение из представленных.
//При написании кода учитывайте, что числа могут быть одинаковыми.
//Необходимо писать общее решение для всех случаев

string line = Console.ReadLine();
string[] splitString = line.Split(' ');

int a = Convert.ToInt32(splitString[0]);
int b = Convert.ToInt32(splitString[1]);
int c = Convert.ToInt32(splitString[2]);
/*
int minValue = 0;
if ((a != 0) && (b != 0) && (c !=0 ))
{
    if (((a != b) && (b != c) && (a != c)))
    {
        if (a < b && b < c)
        {
            minValue = a;
        }
        else
        {
            if (a < b && c < a)
            {
                minValue = c;
            }
            else if (b < a && b < c)
            {
                minValue = b;
            }
            else
            {
                minValue = c;
            }
        }
    }
    else if (a == b && c < b)
    {
        minValue = c;
    }
    else if (b == c && a < c)
    { minValue = a; }
    else if (a == b && b == c)
    {
        minValue = c;
    }
    else { minValue = b; }

}
else 
{ minValue = 0; }
Console.WriteLine(minValue);
*/
int minValue = (a <= b && a <= c) ? a : (b <= a && b <= c) ? b : c;

Console.WriteLine(minValue);