// See https://aka.ms/new-console-template for more information


public static class Program
{
    public static void Main()
    {
        /*
        Задача 1
        Необходимо вывести в консоль средний бал пяти участников конкурса с тремя этапами. 
        Программа почти готова, осталось только написать метод, который берет три численных
         значения и возвращает их среднее арифметическое.
         */
        /*
        Console.WriteLine(Average(3, 4, 5));
        Console.WriteLine(Average(10, 18, 5));
        Console.WriteLine(Average(1, 0, 8));
        Console.WriteLine(Average(1, 1, 4));
        Console.WriteLine(Average(15, 15, 15));


    }

    public static int Average(int a, int b, int c)
    {
        int sa = (a + b + c) / 3;
        return sa;
    }
        */
    }
    /*
    Task 2
Студент скопировал чужую курсовую работу и заменил в ее тексте русские буквы "е" на латинские,
чтобы она прошла проверку на уникальность.Напишите метод для программы, которая проверяет,
 есть ли в тексте латинская буква "e" в любом регистре, и выводит соответствующие уведомления.
    */
    /*
    public static void Main2()
    {
        string courseWork = Console.ReadLine();
        if (IsTextIncludesChar(courseWork))
        {
            Console.WriteLine("В тексте присутствуют латинские символы!");
        }
        else
        {
            Console.WriteLine("Латинские символы отсутствуют");
        }
    }
    public static bool IsTextIncludesChar(string text)
    {

        foreach (char c in text)

        {

            if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))

            {

                return true;

                break;

            }

        }

        return false;


        //Пишите тело вашего метода здесь 

    }
    */
}


