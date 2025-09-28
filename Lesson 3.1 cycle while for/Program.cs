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
/*
int startValue = int.Parse(Console.ReadLine());
        int endValue = int.Parse(Console.ReadLine());

        //int startNumber = startValue < 0 ? -startValue : startValue;

        //int endNumber = endValue < 0 ? -endValue : endValue;
        int sum = 0;
        startValue = startValue < 0 ? 0 : startValue;
        endValue = endValue < 0 ? 0 : endValue;
        if (startValue > endValue)
        {
            for (int i = endValue; i < startValue; i++)
            {
                int k = i < 1 ? -i : i;
                if (k > 1 && (k == 2 || k % 2 != 0))
                {
                    for (int n = 3; n <= Math.Sqrt(k); n += 2)
                    { k = k % n != 0 ? k : 0; }
                    sum += k;
                }
                else
                    k = 0;




                //Console.Write("i= " + i + "  ");
                //Console.WriteLine("sum= " + sum);
            }

        }
        else
        {
            for (int i = startValue; i <= endValue; i++)
            {
                int k = i < 1 ? -i : i;
                if (k > 1 && (k == 2 || k % 2 != 0))
                {
                    for (int n = 3; n <= Math.Sqrt(k); n += 2)
                    { k = k % n != 0 ? k : 0; }
                    sum += k;
                }
                else
                    k = 0;
                Console.Write("i= " + i + "  ");
                Console.WriteLine("sum= " + sum);
            }

        }
        Console.WriteLine($"Сумма простых чисел = {sum}");
    }
    
}
 
*/
//Изменена задача 5
/*
 *  
 Задача 6, Шаг 13 по курсу из Stepik
В консоль вводятся два числа. 
В обоих числах есть одна общая цифра.
 Выведите в консоль цифру, которая есть в
  обоих числах через пробел столько раз,
  сколько раз она встречается в первом числе.
  */
/*

int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());

string firstDigits = firstNumber.ToString();
string secondDigits = secondNumber.ToString();

char commonDigit = ' ';

// 2. Проверяем каждую цифру
for (int i = 0; i < firstDigits.Length; i++)
{


    for (int j = 0; j < secondDigits.Length; j++)
    {
        if (firstDigits[i] == secondDigits[j])
        {
            commonDigit = firstDigits[i];
            break;
        }


    }

    if (commonDigit != ' ') break; // Нашли общую цифру, выходим

}
// 2. Считаем сколько раз эта цифра встречается в первом числе
if (commonDigit != ' ')
{
    int count = 0;
    for (int i = 0; i < firstDigits.Length; i++)
    {
        if (firstDigits[i] == commonDigit)
        {
            count++;
        }
    }
    // 3. Выводим цифру count раз
    for (int i = 0; i < count; i++)
    {
        Console.Write(commonDigit + " ");
    }
}


    }

}
 */
/*Задача 7 Шаг 14

Гипотеза Сиракуз утверждает, что любое натуральное число сводится к единице
    в результате повторения следующих действий над самим числом и результатами этих действий:

Если число четное, то его следует разделить на 2

Если нечетное, то умножить его на 3, а затем прибавить 1

В попытке доказать эту гипотезу, Лотар Коллатц написал программу, 
которая должна выводить в консоль количество действий, которые необходимо совершить над введенным в консоль числом,
прежде чем оно сведется к единице.

1. 5 - это нечётное число, значит 5 * 3 + 1 = 16
2. 16 - чётное, 16 / 2 = 8
3. 8 - чётное, 8 / 2 = 4
4. 4 - чётное, 4 / 2 = 2
5. 2 - чётное, 2 / 2 = 1

Итого потребовалось 5 действий

 int number = int.Parse(Console.ReadLine());
        int count = 0;
        if (number != 1)
        {
            do
            {

                if (number % 2 == 0)
                { number /= 2; }
                else
                {
                    number = (number * 3) + 1;
                }
                count++;
                Console.Write($"count = {count}  ");
                Console.WriteLine($"number = {number}");
            }
            while (number > 1);
        }
        Console.WriteLine($"Количество необходимых действий над числом - {count}");
*/
//Выгрузка на гит 6 и 7 задачи
