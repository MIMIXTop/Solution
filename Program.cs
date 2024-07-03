using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics.CodeAnalysis;

class Program
{
    public int second(int[] arr)
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

    public void swapMAX_MIN(ref int[] arr)
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

    public void print(int[] arr)
    {
        foreach (int now in arr)
        {
            Console.Write($"{now} ");
        }
        Console.ReadKey();
    }

    public int unique_elem(int[] arr)
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

    public int Sum(int[] arr)
    {
        int sumArr = 0;

        foreach (int now in arr)
        {
            sumArr += now;
        }
        return sumArr;
    }

    public int maxARR(int[] arr)
    {
        int max = arr[1];

        foreach (int now in arr)
        {
            if (max < now)
                max = now;
        }
        return max;
    }

    public void sort(int[] arr)
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

    public void sortMin(int[] arr)
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

    public void change(int[] arr)
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

    public int first_unique(int[] arr)
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
        Program pr = new Program();

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
                    Console.WriteLine($"Сумма равна: {pr.Sum(arr)}");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine($"{pr.maxARR(arr)}");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine($"Второй по значению {pr.second(arr)}");
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine($"Количество уникальных элементов: {pr.unique_elem(arr)}");
                    Console.ReadKey();
                    break;
                case 5:
                    Console.WriteLine($"Первый уникальных элементов: {pr.first_unique(arr)}");
                    Console.ReadKey();
                    break;
                case 6:
                    pr.swapMAX_MIN(ref arr);
                    pr.print(arr);
                    break;
                case 7:
                    temp = arr[0];
                    arr[0] = arr[arr.Length - 1];
                    arr[arr.Length - 1] = temp;
                    pr.print(arr);
                    break;
                case 8:
                    pr.sort(arr);
                    pr.print(arr);
                    break;
                case 9:
                    pr.sortMin(arr);
                    pr.print(arr);
                    break;
                case 10:
                    pr.change(arr);
                    pr.print(arr);
                    break;
                case 11:
                    pr.print(arr);
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
