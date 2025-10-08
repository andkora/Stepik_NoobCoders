// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;

namespace Array_task1_step7;

public static class Program
{
    public static void Main()
    {
        /*
         * Задача 1
Напишите программу, которая берет введенный пользователем текст  
        и отображает его вертиально
        */
        /*
        string line = Console.ReadLine();

        for (int i = 0; i < line.Length; i++)
        {

            Console.WriteLine(line[i]);
        }
        */

        /*
         * Задача 2
        Дано два целых числа одинаковой длины. Учитывая, что метод Console.ReadLine( ) всегда возвращает строку, а строка - это массив символов, напишите программу,
         которая должна пройти по всем элементам этих чисел и сравнить их. 
         Первый элемент первого числа сравнивается с первым элементом второго, и т.д. 
         В консоль должен быть выведен ответ :

        "Совпадение n элементов", где n - количество совпавших элементов.

        Пример:

        13456 

        23550

        У этих чисел одинаковые 2ой и 4ый элемент, следовательно ответ:

        "Совпадение 2 элементов"
        

        string num1 = Console.ReadLine();
        string num2 = Console.ReadLine();

        int[] numbers1 = new int[num1.Length];
        int[] numbers2 = new int[num2.Length];

        for (int i = 0; i < num1.Length; i++)
        {
            char c = num1[i];                    // получаем символ
            string digitString = c.ToString();    // преобразуем в строку
            int number = int.Parse(digitString);  // преобразуем в число
            numbers1[i] = number;                  // сохраняем в массив
        }

        for (int j = 0; j < num2.Length; j++)
        {
            char c = num2[j];                    // получаем символ
            string digitString = c.ToString();    // преобразуем в строку
            int number = int.Parse(digitString);  // преобразуем в число
            numbers2[j] = number;                  // сохраняем в массив
        }
        int cout = 0;

        for (int i = 0; i < num1.Length; i++)
        {
            if (numbers1[i] == numbers2[i])
            {
                cout++;
            }
        }
        Console.WriteLine($"Совпадение {cout} элементов");
        
        Решение тоже правильное
        */
        /*
        int cout = 0;

        for (int i = 0; i < num1.Length; i++)
        {
            if (num1[i] == num2[i])
            {
                cout++;
            }
        }
        Console.WriteLine($"Совпадение {cout} элементов");
        */

        /*
         * Задача 3
         * Ваша программа так же получает на вход два числа в строковом формате, 
       но теперь они  могут быть разной длины.
        Найдите уникальный элемент первого числа
         (значение, которое встречается  только 1 раз в обоих массивах)

  Пример:

  12335

  1458

  В данном случае уникально число 2 - оно существует в одном экземпляре

  1 и 5 есть во втором массиве, а 3 встречается дважды в первом

  В итоге ответ:

  "Уникально число 2"

  */
        /*
        string num1 = Console.ReadLine();
        string num2 = Console.ReadLine();

        char[] AllDigit = new char[num1.Length + num2.Length];

        for (int i = 0; i < num1.Length; i++)
        {
            AllDigit[i] = num1[i];
        }

        for (int i = 0; i < num2.Length; i++)
        {
            AllDigit[num1.Length + i] = num2[i];


        }
        // for (int i = 0; i < AllDigit.Length; i++)
        //  { Console.Write($"{AllDigit[i]} "); }


        for (int i = 0; i < num1.Length; i++)
        {
            int count = 0;
            char exNum;
            exNum = num1[i];
            for (int j = 0; j < AllDigit.Length; j++)
            {
                if (exNum == AllDigit[j])

                {
                    count++;

                }
            }
            if (count == 1)
            {
                Console.WriteLine($"Уникально число {exNum}");

            }
        
        }
        */


        /*
         * Задача 4
     В консоль вводится строка с определенной последовательностью чисел. 
     Числа введены через пробел.
      Доработайте программу, которая считает сумму
       всех четных чисел в этой последовательности.
       */
        /*
        int summ = 0;
        string line = Console.ReadLine();
        string[] array = line.Split(' ');
        int[] numbers = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {

            numbers[i] = int.Parse(array[i]);
            int digit = numbers[i];
            if ((digit % 2) == 0)
            {

                summ += digit;
            }
        }


        //Ваш код

        Console.WriteLine(summ);
        */

        /*
         * Task 5
      И снова строка с последовательностью чисел,
       но на это раз вам необходимо написать программу,
        которая выводит в консоль наименьшее и наибольшее значение.
         В исходной последовательности есть как минимум два различных числа.
          Для начала преобразуйте ее в целочисленный массив, используя алгоритм
           из предыдущего задания
           */
        /*
        string line = Console.ReadLine();
        string[] array = line.Split(' ');
        int[] numbers = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            numbers[i] = int.Parse(array[i]);
        }
        int max = numbers[0];
        int min = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (max < numbers[i]) max = numbers[i];
            if (min > numbers[i]) min = numbers[i];

        }





        // Ваш код       

        Console.WriteLine($"Наименьшее значение = {min}");
        Console.WriteLine($"Наибольшее значение = {max}");

        */


        /*Task 6
         * Итак, в консоль вводятся четыре ваши оценки через запятую. Значения могут быть: 2, 3, 4, 5.

Если в вашей ведомости есть ХОТЬ одна двойка - программа выводит : "Ну что, студент, пора долг Родине отдать"

Если есть хоть одна тройка, но нет двоек: "Прощай стипендия!"

Если двоек и троек нет: "Живи пока, через полгода увидимся"

И если все пятерки - "О, отличник появился! На олимпиаду пойдешь" 
*/

        /*
        string grades = Console.ReadLine();
        string[] array = grades.Split(", ");
        int[] digits = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        { digits[i] = int.Parse(array[i]); }
        int four = 0;
        int five = 0;
        bool three = true;
        bool two = true;


        for (int i = 0; i < digits.Length; i++)
        {

            if ((digits[i] > 5) || (digits[i] < 2)) { five = 0; four = 0; break; }
            if (digits[i] == 2) { two = false; break; }
            if (digits[i] == 3) { three = false; }
            if (digits[i] == 5) five++;
            if (digits[i] == 4) four++;

        }

        if (two == false) Console.WriteLine("Ну что, студент, пора долг Родине отдать");
        if (three == false && two == true) Console.WriteLine("Прощай стипендия!");
        if ((three == true && two == true) && four > 0) Console.WriteLine("Живи пока, через полгода увидимся");
        if (five == digits.Length) Console.WriteLine("О, отличник появился! На олимпиаду пойдешь");

        */
        /*
        Задача 7
        Дяде Васе позвонили из "службы безопасности банка" и попросили назвать номер карты.
         Сомневаясь в истинности этого звонка, он решил назвать номер в обратном порядке.
          Но дядя Вася не был бы дядей Васей, если бы на его карте не отсутствовали первые две цифры.
           Помогите ему сохранить сбережения и на место отсутствующих первой и второй цифр поставьте
            значения минимальной и максимальной цифры в номере соответственно, затем весь номер переверните.
            */
        /*
        string cardNumber = Console.ReadLine();

        int[] digits = new int[cardNumber.Length];
        for (int i = 0; i < cardNumber.Length; i++)
        { digits[i] = int.Parse(cardNumber[i].ToString()); }
        int max = 0;
        int min = 0;
        for (int i = 0; i < digits.Length; i++)
        {
            max = digits[0];
            min = digits[0];
            foreach (int num in digits)
            {
                max = num > max ? num : max;
                min = num < min ? num : min;
            }

        }
        // Console.WriteLine(max);
        //Console.WriteLine(min);
        char[] charArray = cardNumber.ToCharArray();
        Array.Reverse(charArray);
        string number = new string(charArray);
        Console.WriteLine($"{number}{max}{min}");
        */


        /*Задача 8
       Реализовать сортировку пузырьком для последовательности целых чисел.
        Последовательность произвольной длины, но содержит не менее двух элементов. 
        В консоль надо вывести все значения через пробел, отсортированные в порядке возрастания.
       */
        
        string line = Console.ReadLine();
        string[] array = line.Split(" ");
        int[] numbers = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            numbers[i] = int.Parse(array[i].ToString());
        }

        for (int i = 0; i < numbers.Length - 1; i++)
        {

            for (int j = 0; j < numbers.Length - i - 1; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    (numbers[j], numbers[j + 1]) = (numbers[j + 1], numbers[j]);

                }


            }


        }
        Console.WriteLine(string.Join(" ", numbers));
        

    }
}
//All task is done for article for Array
