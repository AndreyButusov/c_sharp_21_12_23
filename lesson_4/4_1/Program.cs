﻿//  1. Задайте одномерный массив, заполненный случайными
//  числами. Определите количество простых чисел в этом 
//  массиве

using System;

namespace Task_4_1
{
    class Program
    {
        static void Main()
        {
            void Print(double[] arr)
            { 
                int size = arr.Length;

                for (int i = 0; i < size; i++)
                    Console.Write($"{arr[i]} ");

                Console.WriteLine();
            }

            double[] MassNums(int size, int from, int to)
            {
                double[] arr = new double[size];
                Random n_new = new Random();

                for (int i = 1; i < size; i++)
                    arr[i] = (n_new.Next(from, to));

                return arr;
            }

            int CountSimpleNum(double[] arr)
            {
                int count = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (FindSimpleNum(arr[i]))
                    {
                        count++;
                    }

                }
                return count;
            }

            bool FindSimpleNum(double Num)
            {
                if (Num < 2)
                    return false;
                for (int i = 2; i < Num; i++)
                {
                    if (Num % i == 0)
                        return false;
                }
                return true;
            }
        int num = int.Parse(Console.ReadLine()!);
        int start = int.Parse(Console.ReadLine()!);
        int stop = int.Parse(Console.ReadLine()!);
        
        double[] mass = MassNums(num, start, stop);
        Print(mass);

        int new_num = CountSimpleNum(mass);
        System.Console.WriteLine(new_num);
        }
    }
}