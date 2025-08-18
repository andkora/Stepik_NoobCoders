// See https://aka.ms/new-console-template for more information
using System;
using System.Net.NetworkInformation;
/*
Console.WriteLine("Введите два целых числа через *");
string line = Console.ReadLine();
string[] splitString = line.Split('*');

int x1 = int.Parse(splitString[0]);
int x2 = int.Parse(splitString[1]);

int sum = x1+x2 ; // Запишите тут Ваш код для вычисления суммы значений x1 и x2
int difference = x1-x2 ; // Запишите тут Ваш код для вычисления разности значений x1 и x2
int multiply = x1*x2 ; // Запишите тут Ваш код для вычисления произведения значений x1 и x2
Console.WriteLine($"{sum} {difference} {multiply}");
*/
/*
Console.WriteLine("Введите пройденное расстояние в метрах");
int n = Convert.ToInt32(Console.ReadLine()); // преобразуем введенную строку в число 
                                             // и присваиваем его значение переменной

int distance = n/1000 ; //Запишите тут Ваш код для вычислений

Console.WriteLine(distance);
*/
/*
Console.WriteLine("Введите пройденное расстояние в метрах");
int n = Convert.ToInt32(Console.ReadLine()); // преобразуем введенную строку в число 
int distance = 1000 - (n % 1000) ;                                       // и присваиваем его значение переменной
 Console.WriteLine(distance);
*/
/*
Console.WriteLine("Введите значение радиуса круга");
double r = Convert.ToDouble(Console.ReadLine()); // преобразуем введенную строку в число 
                                               // и присваиваем его значение переменной

double pi = Math.PI; //  число пи;

//формулы для вычислений можно найти в интернете

double perimeter = 2*pi*r ; //Запишите тут код для вычисления периметра круга
double area = pi*r*r ; //Запишите тут код для вычисления площади круга

Console.WriteLine($"Периметр: {perimeter}, площадь: {area}");
*/
/* //вычисляем цену за килограмм, вбитую в граммах и округляем до 2х знаков после запятой
Console.WriteLine("Введите вес товара");
var weight = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Введите цену товара");
var price = Convert.ToDecimal(Console.ReadLine());

var fairPrice = price / (weight / 1000);
fairPrice = Math.Round(fairPrice, 2);//Тут должен быть ваш код

Console.WriteLine($"Цена товара за килограмм = {fairPrice}");
*/
/* Дядя Вася меряет свой дачный стол старой рулеткой 5м, пытаясь найти площадь. Стол имеет форму прямоугольника.

Напишите программу, которая вычисляет площадь стола, на основании введённых длины и ширины стола (в метрах).

Имейте ввиду, что у рулетки отломаны первые 20 см и дядя Вася об этом не знает (он напишет 1.2 м, хотя в реальности измерил 1 м)*/
/*
Console.WriteLine("Введите два числа через пробел: длина и ширина стола");
string line = Console.ReadLine();
string[] splitString = line.Split(' ');

double length = Convert.ToDouble(splitString[0]); // длина
double width = Convert.ToDouble(splitString[1]); // ширина

double square = (length - 0.2) * (width - 0.2); //Тут будет Ваш код
square = Math.Round(square, 2);
Console.WriteLine($"Площадь стола: "+square);
*/
/*
int a = 47;
int b = --a + 4;
Console.WriteLine(a);
Console.WriteLine(b);
int x = 56;
int y = x-- * 4;
Console.WriteLine(x);
Console.WriteLine(y);
*/
/*
int x = 7;
int y = x++ + ++x * 2;
Console.WriteLine(x);
Console.WriteLine(y);
*/

//Напишите программу, которая преобразовывает число из десятеричной системы в шестнадцатеричную

string line = Console.ReadLine(); // ввод числа в десятеричной системе 

int x = int.Parse(line);

string answer;
answer = Convert.ToString(x,16);
//Запишите тут Ваш код

Console.WriteLine(answer);