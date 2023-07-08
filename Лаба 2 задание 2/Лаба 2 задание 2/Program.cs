using System;

namespace Лаба_2_задание_2
{
    class Program
    {
        static int Z(int x)  //Метод для определения размера массива
        {
            int z = 1;
            do
            {
                x = x / 10;
                if (x > 0) z++;
                else break;
            } 
            while (x > 0);
            return z;
        }
        static int [] Num (int x)   //Метод для преобразования цифр числа в элементы массива
        {
            int[] n = new int[Z(x)];
            int i = Z(x) - 1;
            do
            {
                int y = x % 10; //Получение от начального числа дробной части при делении на 10 (получение элемента массива)
                x = (x - y) / 10; // Избавление от дробной части (найденного элемента массива) 
                n[i] = y; //Запись значения элемента в конец массива
                i--;
            }
            while (x > 0);
            return n;
        }
        static void Main(string[] args)
        {
            int index1 = -1, index2 = -1;
            Console.Write("Введите число:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите b:");
            int b = Convert.ToInt32(Console.ReadLine());
            int[] t = new int[Z(x)];
            t = Num(x);
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] == a) {index1 = i; } //Если значение элемента массива равно числу "a", записывает его индекс 
                if (t[i] == b) {index2 = i; } //Если значение элемента массива равно числу "b", записывает его индекс 
            }
                if (index1 == -1 | index2 == -1) Console.WriteLine("Одной из цифр a и b нет в заданном числе"); //Если цифр a и/или b нет в массиве, оставляет значение индекса по умолчанию и выводит ошибку
                else
                if (index1 > index2) Console.WriteLine("Элемент a: " + a + " находится справа от b"); //Сравнение индексов и определение положения чисел
                else Console.WriteLine("Элемент b:" + b + " находится справа от a");

        }
    }
}
