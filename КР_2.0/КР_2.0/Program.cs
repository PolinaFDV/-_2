using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КР_2._0
{
    internal class Program
    {
        static int ToInt()
        {
            while (true)
            {
                string value = Console.ReadLine();
                if (int.TryParse(value, out int result))
                {
                    return result;
                }
                Console.WriteLine("Ошибка ввода");
                Console.WriteLine("Введите целое число");
            }
        }
        static float ToFloat()
        {
            while (true)
            {
                string value = Console.ReadLine();
                if (float.TryParse(value, out float result))
                {
                    return result;
                }
                Console.WriteLine("Ошибка ввода");
                Console.WriteLine("Введите дробное число");
            }
        }
        static double ToDouble()
        {
            while (true)
            {
                string value = Console.ReadLine();
                if (double.TryParse(value, out double result))
                {
                    return result;
                }
                Console.WriteLine("Ошибка ввода");
                Console.WriteLine("Введите дробное число");
            }
        }
        static string ToString()
        {
            while (true)
            {
                string value = Console.ReadLine().Trim();
                if (value.Length > 0)
                {
                    return value;
                }
                Console.WriteLine("Ошибка ввода");
                Console.WriteLine("Введите непустую строку");
            }
        }

        static int Mod(int[] arr, out int ch, out int ne_ch, out int mod_5)
        {
            ch = 0;
            ne_ch = 0;
            mod_5 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    ch++;
                }
                else
                {
                    ne_ch++;
                }
                if (arr[i] % 5 == 0)
                {
                    mod_5++;
                }
            }
            return mod_5;
        }

        static int[] Full_Array(int len)
        {
            int[] arr = new int[len];
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("Введите число");
                arr[i] = ToInt();
            }
            return arr;
        }
        static double[] Full_Array_Double(int len)
        {
            double[] arr = new double[len];
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("Введите число");
                arr[i] = ToDouble();
            }
            return arr;
        }
        static void ShowArray(int[] arr)
        {
            for (int i = 0; i < arr.Length;i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine();
        }
        static void ShowArray(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine();
        }

        static float Suma_and_Even(int[] arr, out int cnt_ne_ch, out int sum)
        {
            cnt_ne_ch = 0;
            sum = 0;
            for (int i = 0;i < arr.Length;i++)
            {
                if (i % 2 != 0)
                {
                    cnt_ne_ch++;
                    sum += arr[i];
                }
            }
            if ((cnt_ne_ch == 0))
            {
                return 0;
            }
            return (float)sum / cnt_ne_ch;
        }

        static int Cnt_bigger_ABS(int[] arr, out int suma, out int cnt)
        {
            suma = 0;
            cnt = 0;
            float even_all;
            for (int i = 0; i < arr.Length; i++)
            {
                suma += Math.Abs(arr[i]);
            }
            if (arr.Length > 0)
            {
                even_all = (float)suma / arr.Length;
            }
            else
            {
                even_all = 0;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i]) > even_all)
                {
                    cnt++;
                }
            }
            return cnt;
        }

        static int SwapIfGreater(ref int a, ref int b)
        {
            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
            return a;
        }

        static int Min_Max_Range(int[] arr, out int min, out int max, out int range)
        {
            Array.Sort(arr);
            min = arr[0];
            max = arr[arr.Length - 1];
            range = max - min;
            return range;
        }
        static double GetStats(int[] arr, out int min, out int max, out double average, out int summ)
        {
            summ = 0;
            min = arr[0];
            max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                else if (arr[i] < min)
                {
                    min = arr[i];
                }
                summ += arr[i];
            }
            if (arr.Length > 0)
            {
                average = (double)summ / arr.Length;
            }
            else
            {
                average = 0;
            }
            return average;
        }

        static bool IndexOf(int[] arr, int value, out int index)
        {
            index = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (value == arr[i])
                {
                    index = i;
                    return true;
                }
            }
            return false;
        }

        static double[] NormalizeAndRound(double[] arr, int digits = 2)
        {
            double max = Math.Abs(arr[0]);
            for (int i = 1; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i]) > max)
                {
                    max = Math.Abs(arr[i]);
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Math.Round(arr[i] / max, digits);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            return arr;
        }

        static int Array_Of_Local_Max(int[] arr, out int length, out int[] new_arr)
        {
            length = 0;
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if ((arr[i] > arr[i - 1]) && (arr[i] > arr[i + 1]))
                {
                    length++;
                }
            }
            new_arr = new int[length];
            int j = 0;
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if ((arr[i] > arr[i - 1]) && (arr[i] > arr[i + 1]))
                {
                    new_arr[j] = arr[i];
                    j++;
                }
            }
            return length;
        }

        static int Find_Index(int[] arr, int a, int b, out int first_idx, out int last_idx)
        {
            first_idx = -1;
            last_idx = -1;
            bool is_first_idx = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if ((arr[i] >= a) && (arr[i] <= b))
                {
                    if (!is_first_idx)
                    {
                        first_idx = i;
                        is_first_idx = true;
                    }
                    last_idx = i;
                }
            }
            return first_idx;
        }

        static int[] Creat_New_Massiv(int[] arr, int a, int b)
        {
            int[] new_massiv;
            int cnt = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if ((arr[i] >= a) && (arr[i] <= b))
                {
                    cnt++;
                }
            }
            new_massiv = new int[cnt];
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if ((arr[i] >= a) && (arr[i] <= b))
                {
                    new_massiv[j] = arr[i];
                    j++;
                }
            }
            return new_massiv;
        }

        static int Replace(int[] arr, int a, int b, int target)
        {
            int cnt = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if ((arr[i] >= a) && (arr[i] <= b))
                {
                    arr[i] = target;
                    cnt++;
                }
            }
            return cnt;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину массива");
            int len = ToInt();
            Console.WriteLine("Введите числа для массива");
            int[] array1 = Full_Array(len);
            while (true)
            {
                Console.WriteLine("-------------\n");
                Console.WriteLine("Введите номер уровня");
                int level = ToInt();
                switch (level)
                {
                    case 1:
                        Console.WriteLine("\n-------------");
                        Console.WriteLine("Level 1");
                        Console.WriteLine("-------------\n");
                        Mod(array1, out int ch, out int ne_ch, out int mod_5);
                        Console.WriteLine("Количество чётных чисел: " + ch);
                        Console.WriteLine("Количество нечётных чисел: " + ne_ch);
                        Console.WriteLine("Количество чисел кратных 5: " + mod_5);
                        Console.WriteLine("-------------\n");


                        float even_ne_ch = Suma_and_Even(array1, out int cnt_ne_ch, out int sum);
                        Console.WriteLine("Сумма элементов под нечётными индексами равна: " + sum);
                        Console.WriteLine("Среднее элементов под нечётными индексами равно: " + even_ne_ch);
                        Console.WriteLine("-------------\n");


                        Cnt_bigger_ABS(array1, out int suma, out int cnt);
                        Console.WriteLine(cnt + " элементов, чей модуль больше среднего");
                        Console.WriteLine("-------------\n");


                        Min_Max_Range(array1, out int min, out int max, out int range);
                        Console.WriteLine("Минимальное число " + min);
                        Console.WriteLine("Максимальное число " + max);
                        Console.WriteLine("Разность между ними " + range);
                        Console.WriteLine("-------------\n");
                        break;
                    case 2:
                        Console.WriteLine("\n-------------");
                        Console.WriteLine("Level 2");
                        Console.WriteLine("-------------\n");
                        Console.WriteLine("Введите начало диапазона");
                        int a2 = ToInt();
                        Console.WriteLine("Введите конец диапазона");
                        int b2 = ToInt();
                        Console.WriteLine("Первый индекс равен " + Find_Index(array1, a2, b2, out int first_idx, out int last_idx));
                        Console.WriteLine("Последний индекс равен " + last_idx);
                        Console.WriteLine("-------------\n");


                        Console.WriteLine($"Массив элементов в диапазоне от {a2} до {b2}");
                        ShowArray(Creat_New_Massiv(array1, a2, b2));
                        Console.WriteLine("-------------\n");


                        Console.WriteLine("Введите число, на которое хотите заменить все элементы из этого диапазона");
                        int target = ToInt();

                        Console.WriteLine($"Количесвто замен равно {Replace(array1, a2, b2, target)}");
                        Console.WriteLine("-------------\n");
                        break;
                    case 3:
                        Console.WriteLine("\n-------------");
                        Console.WriteLine("Level 3");
                        Console.WriteLine("-------------\n");

                        Console.WriteLine("Введите длину массива");
                        int len3 = ToInt();
                        int[] array3 = Full_Array(len3);
                        Console.WriteLine("Количество локальных максимумов равно " + Array_Of_Local_Max(array3, out int length, out int[] new_arr3));
                        ShowArray(new_arr3);
                        break;
                    case 4:
                        Console.WriteLine("\n-------------");
                        Console.WriteLine("Level 4");
                        Console.WriteLine("-------------\n");
                        Console.WriteLine("Введите два числа");
                        int a = ToInt();
                        int b = ToInt();
                        Console.WriteLine("Первое число равно " + a);
                        Console.WriteLine("Второе число равно " + b);
                        SwapIfGreater(ref a, ref b);
                        Console.WriteLine("-------------\n");
                        Console.WriteLine("Первое число равно " + a);
                        Console.WriteLine("Второе число равно " + b);
                        Console.WriteLine("-------------\n");


                        Console.WriteLine("Введите длину массива");
                        int len4 = ToInt();
                        Console.WriteLine("Введите числа для массива");
                        int[] array4 = Full_Array(len4);
                        GetStats(array4, out int min4, out int max4, out double average, out int summ);
                        Console.WriteLine("Минимальное число " + min4);
                        Console.WriteLine("Максимальное число " + max4);
                        Console.WriteLine("Среднее арифметическое " + average);
                        Console.WriteLine("-------------\n");
                        Console.WriteLine();


                        Console.WriteLine("Введите число, индекс которого хотите найти");
                        int value = ToInt();
                        Console.WriteLine(IndexOf(array4, value, out int index));
                        Console.WriteLine("Индекс данного элемента равен " + index);
                        Console.WriteLine("\n-------------\n");


                        Console.WriteLine("Введите числа для нового массива");
                        double[] arr_double = Full_Array_Double(len4);
                        Console.WriteLine("Введите до скольки знаков после запятой округлять элементы");
                        int digits = ToInt();
                        NormalizeAndRound(arr_double, digits);
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Такого уровня не существует");
                        break;
                }
            }
        }
    }
}
