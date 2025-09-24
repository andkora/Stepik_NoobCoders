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

int num = int.Parse(Console.ReadLine());
long fac=1;

for (int i = 2; i <= num; i++) 
{
    fac = fac * i;
    Console.Write("i= "+i);
    Console.Write("  ");
    Console.WriteLine("fac= "+fac);
}

//Добавлена 3я и 4я задачи