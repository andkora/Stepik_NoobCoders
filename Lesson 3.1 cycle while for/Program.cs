// See https://aka.ms/new-console-template for more information

using System;

/* Простая задачка для закрепления материала. 
 * Пользователь вводит в консоль число. Выведите на экран приветственное сообщение
 * "Hello, NoobCoders!" несколько раз, в зависимости от того, 
 * какое число было введено пользователем.
 
int num = int.Parse(Console.ReadLine());

for (int i = 0; i < num; i++)
{
    Console.WriteLine("Hello, NoobCoders!");
}
*/
/* В консоль пользователем вводится целое положительно число.
 * Используя цикл while, напишите программу, которая выводит на экран
 * через пробел числа от нуля до введенного пользователем числа включительно.
 */
/*
  int i=0;
        int num = int.Parse(Console.ReadLine());
while (i <= num)

        {

            Console.Write(i);

            if (i < num)

            {

                Console.Write(" "); // Добавляем пробел, если это не последнее число

            }

            i++;

        }

        Console.WriteLine();
 */
//добавлены 2 задачи
/*
Теперь пользователь вводит целое положительное число, 
    но от вас требуется вывести на экран все числа от нуля столбиком,
    чтобы при этом сумма всех чисел в столбце была строго меньше введенного пользователем числа.
     */
/*
int i = 0;
int num = int.Parse(Console.ReadLine());
int sum = 0;
do

{
    // if (sum > num)
    //{ break; }
    Console.WriteLine(i);
    // Console.Write(" ");
    sum = sum + i;
    // Console.WriteLine(sum);
    i++;
}
while (sum < (num - i));


/* Факториалом натурального числа n называют произведение всех натуральных чисел от 1 до n включительно.
 * Напишите программу для вычисления факториала введенного пользователем числа.
  */
/*
int num = int.Parse(Console.ReadLine());
long fac=1;

for (int i = 2; i <= num; i++) 
{
    fac = fac * i;
    Console.Write("i= "+i);
    Console.Write("  ");
    Console.WriteLine("fac= "+fac);
}
*/
//Добавлена 3я и 4я задачи
//Задача 5
/* Напишите программу, которая считает сумму всех простых чисел в определенном диапазоне
 */
int startValue = int.Parse(Console.ReadLine());
int endValue = int.Parse(Console.ReadLine());

//int startNumber = startValue < 0 ? -startValue : startValue;

//int endNumber = endValue < 0 ? -endValue : endValue;

int sumR = 0;
int sumL = 0;
if (startValue >= 0)
{
    for (int i = startValue; i > 1; i--)
    {
        int k;
        for (int n=2;n<startValue;n++)
        {
            k = i;
            k = ((startValue % n) == 0) && (i!= n) ? k = 0 : k;
            sumR += k;
           
        }
                Console.Write("i= " + i + "  ");
    Console.WriteLine("sum= " + sumR);
    }
}

else
{
    for (int i = startValue; i < -1; i++)
    {
        for (int n = 2; n > startValue; n++)
        {
            i = (startValue % n == 0) && (n != i) ? i = 0 : i;
        }
        sumR += i;
        Console.Write("i= " + i + "  ");
        Console.WriteLine("sum= " + sumR);
    }
    
}
 sumR = sumR < 0 ? -sumR : sumR;

if (endValue >= 0)
{
    for (int i = endValue; i > 1; i--)
    {
        for (int n = 2; n < endValue; n++)
        {
            i = (startValue % n == 0) && (n != i) ? i = 0 : i;
        }
        sumL += i;
        Console.Write("i= " + i + "  ");
        Console.WriteLine("sum= " + sumL);
    }
}

else
{
    for (int i = endValue; i < -1; i++)
    {
        int k;
        for (int n = -2; n < endValue; n--)
        {
            k = i;
            k = (endValue % n == 0) && (n != i) ? k = 0 : k;
            sumL += k;
        }
        Console.Write("i= " + i + "  ");
        Console.WriteLine("sum= " + sumL);
    }

}
sumL = sumL < 0 ? -sumL : sumL;
int sum = sumL + sumR;
Console.WriteLine();

Console.WriteLine("sum = " + sum);