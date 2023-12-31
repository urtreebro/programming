﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classarrays
{
    partial class Program
    {
        public class OneDimensionalArray
        {
            private int n;

            private bool userInput = false;

            private int[] array;

            public OneDimensionalArray(int n, bool userInput)
            {
                this.n = n;

                this.userInput = userInput;

                if (userInput) 
                {
                    Console.WriteLine($"Input {n} numbers");
                    UserInput(); 
                }
                else 
                { 
                    RandomInput();
                }
            }   

            public void RandomInput()
            {
                array = new int[n];

                Random rnd = new();

                for (int i = 0; i < array.Length; i++)
                {
                    int value = rnd.Next(-1000, 1000);
                    array[i] = value;
                }
            }

            public int[] UserInput()
            {
                int[] array = new int[n];

                for (int i = 0; i < n; i++)
                {
                    if (int.TryParse(Console.ReadLine(), out int num))
                    {
                        array[i] = num;
                    }
                    else
                    {
                        Console.WriteLine("Error: couldn't convert into int");
                    }
                }
                return array;
            }

            public void PrintArray()
            {
                Console.WriteLine(string.Join(" ", array));
            }

            public double GetAverageNum()
            {
                double sum = 0;

                foreach (int num in array)
                {
                    sum += num;
                }
                double average = sum / n;
                return average;
            }

            public int[] GetArrayAbs100()
            {
                int newLength = n;

                foreach (int num in array)
                {
                    if (Math.Abs(num) > 100)
                    {
                        newLength--;
                    }
                }

                int[] newArray = new int[newLength];

                int newIndex = 0;

                for (int i = 0; i < n; i++)
                {
                    if (Math.Abs(array[i]) <= 100)
                    {
                        newArray[newIndex] = array[i];
                        newIndex++;
                    }
                }
                return newArray;
            }

            public int[] GetArrayWithoutDuplicates()
            {
                int newLength = n;

                for (int i = 0; i < n; i++)
                {
                    for (int j = i; j < n; j++)
                    {
                        if (i != j && array[i] == array[j])
                        {
                            newLength--;
                            break;
                        }
                    }
                }

                int[] newArray = new int[newLength];

                int newIndex = 0;

                for (int i = 0; i < n; i++)
                {
                    if (!newArray.Contains(array[i]))
                    {
                        newArray[newIndex] = array[i];
                        newIndex++;
                    }
                }
                return newArray;
            }
        }
    }
}

