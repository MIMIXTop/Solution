using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void swapBeginEnd(int[] arr)// Новый метод меняющий первый и последний элемент массива местами 
    {
        int temp;
        
        temp = arr[0];
        arr[0] = arr[arr.Length - 1];
        arr[arr.Length - 1] = temp;
    }
    
    static int second(int[] arr)
    {
        int first = arr[0];
        int second = first;

        foreach (int now in arr)
        {
            if (first < now)
            {
                second = first;
                first = now;
            }
        }
        return second;
    }

    static void swapMAX_MIN(ref int[] arr)
    {
        int temp, max = arr[0], min = arr[0];
        int max_i = 0, min_i = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (max < arr[i])
            {
                max_i = i;
                max = arr[i];
            }
        }
        for (int i = 0; i < arr.Length; i++)
        {
            if (min > arr[i])
            {
                min_i = i;
                min = arr[i];
            }
        }
        
        temp = arr[max_i];
        arr[max_i] = arr[min_i];
        arr[min_i] = temp;
    }

    static void print(int[] arr)
    {
        foreach (int now in arr)
        {
            Console.Write($"{now} ");
        }
    }

    static int unique_elem(int[] arr)
    {
        HashSet<int> hs = new HashSet<int>();
        foreach (var now in arr)
        {
            if (hs.Contains(now))
            {
                hs.Remove(now);
            }
            else
            {
                hs.Add(now);
            }
        }
        return hs.Count;
    }

    static int Sum(int[] arr)
    {
        int sumArr = 0;

        foreach (int now in arr)
        {
            sumArr += now;
        }
        return sumArr;
    }

    static int maxARR(int[] arr)
    {
        int max = arr[1];

        foreach (int now in arr)
        {
            if (max < now)
                max = now;
        }
        return max;
    }

    static void sort(int[] arr)
    {
        int temp;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
    }

    static void sortMin(int[] arr)
    {
        int temp;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] < arr[j])
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
    }

    static void change(int[] arr)
    {
        List<int> temp = new List<int>();
        
        foreach (int now in arr)
        {
            if (now % 2 == 0)
                temp.Add(now);
        }
        foreach (int now in arr)
        {
            if (now % 2 != 0)
                temp.Add(now);
        }
        for (int i = 0; i < temp.Count; i++)
        {
            arr[i] = temp[i];
        }
    }

    static int first_unique(int[] arr)
    {
        HashSet<int> hs = new HashSet<int>();
        foreach (var now in arr)
        {
            if (hs.Contains(now))
            {
                hs.Remove(now);
            }
            else
            {
                hs.Add(now);
            }
        }
        return hs.FirstOrDefault();
    }

    static void Main()
    {
        bool finish = true;
        int temp;
        Random rand = new Random();
        
        Console.WriteLine("Введите размер массива: ");
        int lenghtArrey;
        
        while (true)
        {
            try
            {
                lenghtArrey = Convert.ToInt32(Console.ReadLine());
                break;
            }
            catch (Exception e)
            {
                Console.WriteLine("Не верный ввод необходимо ввести число");
            }
        }
        
        int[] arr = new int[lenghtArrey];

        for (int i = 0; i < lenghtArrey; i++)
        {
            arr[i] = rand.Next(0, 30);
        }
        while (finish)
        {
            Console.Clear();
            Console.WriteLine("""
                              Выберите действие

                              1.Вывести сумму элементов массива 
                              2.Вывести максимальный элемент 
                              3.Вывести второе по величине значение в массиве
                              4.Вывести количество уникальных элементов в массиве
                              5.Вывести первый уникальный элемент массива
                              6.Поменять местами элементы с максимальным и минимальным значениями в массиве
                              7.Обменять местами значение первого и последнего элементов массива
                              8.Отсортировать массив по возрастанию 
                              9.Отсортировать массив по убыванию
                              10.Переместить все четные элементы массива в начало, а нечетные — в конец массива
                              11.Вывести массив в консоль
                              0.Завершить работу
                              """);
            int n;
            
            while (true)
            {
                try
                {
                    n = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Не верный ввод необходимо ввести число");
                }
            }
            
            switch (n)
            {
                case 1:
                    Console.WriteLine($"Сумма равна: {Sum(arr)}");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine($"{maxARR(arr)}");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine($"Второй по значению {second(arr)}");
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine($"Количество уникальных элементов: {unique_elem(arr)}");
                    Console.ReadKey();
                    break;
                case 5:
                    Console.WriteLine($"Первый уникальных элементов: {first_unique(arr)}");
                    Console.ReadKey();
                    break;
                case 6:
                    swapMAX_MIN(ref arr);
                    print(arr);
                    Console.ReadKey();
                    break;
                case 7:
                    swapBeginEnd(arr);
                    print(arr);
                    Console.ReadKey();
                    break;
                case 8:
                    sort(arr);
                    print(arr);
                    Console.ReadKey();
                    break;
                case 9:
                    sortMin(arr);
                    print(arr);
                    Console.ReadKey();
                    break;
                case 10:
                    change(arr);
                    print(arr);
                    Console.ReadKey();
                    break;
                case 11:
                    print(arr);
                    Console.ReadKey();
                    break;
                case 0:
                    finish = false;
                    break;
                default:
                    Console.WriteLine("Такой функции в программе нет");
                    break;
            }
        }
    }
}
