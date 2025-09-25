// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics.CodeAnalysis;

int startValue = int.Parse(Console.ReadLine());
int k;
int sumR=0;
int i = 10;
for (int n = 2; n < startValue; n++)
{
    k = i;
    k = ((startValue % n) == 0) && (i != n) ? k = 0 : k;
    sumR += k;
    Console.Write("i= " + i + "  ");
    Console.Write("k= " + k + "  ");
    Console.WriteLine("sum= " + sumR);
}

