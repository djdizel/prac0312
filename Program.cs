using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{/// <summary>
/// Заполнить одномерный массив и вывести в консоль
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = Size();
            int[] omas = Input(size);
            Output(omas);
            Console.Read();
        }
        static int Size()
        {
            Console.Write("Введите размер = ");
            int size;
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.WriteLine("Ошибка!");
            }
            return size;
        }
        static int[] Input(int size)
        {
            int[] omas = new int[size]; 
            Console.WriteLine("Заполнение одномерного массива");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"omas[{i}] =");
                omas[i] = Convert.ToInt32(Console.ReadLine());
            }
            return omas;
        }
        static void Output(int[] omas)
        {
            Console.WriteLine("Вывод одномерного масива");
            for (int i = 0; i < omas.Length; i++)
            {
                Console.WriteLine($"omas[{i}] = {omas[i]}");
            }
        }
    }
}
