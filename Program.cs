using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

        namespace ConsoleApp2
{/// <summary>
/// Массив предназначен для хранения роста 12 чел с помощью rng заполнить массив целыми значениями 
/// лежащими в диапозоне 163-190 вывести значение элементов циклом foreach,найти ср знач роста 
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] omas = Input();
            int v = Avg(omas);
            Output($"Среднее значение{v}");
            Console.Read();
        }
        static int[] Input()
        {
            int a = 0;
            int[] omas = new int[12];
            Random rng = new Random();
            Console.WriteLine("Вывод одномерного масива");
            foreach (int i in omas)
            {
                omas[i] = rng.Next(163, 190);
                Console.WriteLine($"omas[{a++}] = {omas[i]}");
            }
            return omas;
        }
        static int Avg(int[] omas)
        {
            int sum = 0;
            foreach (int i in omas)
            {
                sum += i;
                Console.WriteLine(sum);
            }
            return sum / omas.Length;
        }
        static void Output(string message)
        {
            Console.WriteLine(message); 
        }
    }
}
