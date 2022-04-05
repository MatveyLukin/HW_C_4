// Семинар 4

// Задача №1
// Условие: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

// int Sumakkber(int A)
// {
//     int sum = 0;
//     for (int i = 1; i <= A; i++)
//     {
//         sum = sum + i;
//     }
//     return sum;
// }

// Console.Write("Введите натуральное число:  ");
// int a = Convert.ToInt32(Console.ReadLine());
// if (a < 1) Console.WriteLine("Введено ненатуральное число");
// else Console.WriteLine($"Сумма чисел от 1 до {a} равна {Sumakkber(a)}");




// Задача №2
// Условие: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// void Dlina(int N)
// {
//     int l = 1;
//     while (Math.Abs(N / 10) >= 1)
//     {
//         N = N / 10;
//         l = l + 1;

//     }
//     Console.WriteLine("Количество цифр в натуральном числе" + l);
// }

// Console.WriteLine("Введите натуральное число ");
// int akkber = Convert.ToInt32(Console.ReadLine());
// Dlina(akkber);







// Задача №3
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// int Factorial(int N)
// {
//     int result = 1;
//     for (int i = 1; i <= N; i++)
//     {
//         result = result * i;
//     }
//     return result;
// }

// Console.Write("Введите натуральное число:  ");
// int n = Convert.ToInt32(Console.ReadLine());
// if (n < 1) Console.WriteLine("Введено ненатуральное число");
// else Console.WriteLine($"Произведение чисел от 1 до {n} равна {Factorial(n)}");




/*
// Задача №4
// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

void bitArray()
{
    int[] a = new int[8];
    for (int i = 0; i < 8; i++)
    {
        a[i] = new Random().Next(0, 2);
        Console.Write(a[i] + " ");
    }
}
bitArray();
*/

// ДЗ C#_4
// Задача №1
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int exponentiation(int A, int B)
// {
//     int sum = A;
//     for (int i = 1; i < B; i++)
//     {
//         sum = sum * A;
//     }
//     return sum;
// }

// Console.WriteLine("Ведите первое число ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ведите второе число ");
// int numberB = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Возведением числа {numberA} в степень {numberB} является => {exponentiation(numberA, numberB)}");


// Задача №2
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

// void Sum(int num)
// {
//     int summary = 0;
//     int akk = num;
//     while (akk > 0)
//     {
//         summary = summary + (akk % 10);
//         akk = akk / 10;
//     }
//     if (num > 0) Console.WriteLine($"Сумма цифр в числе равна {summary}");
//     else Console.WriteLine($"Введено некорректное значение {num}");
// }


// Console.WriteLine("Введите натуральное число   ");
// int result = Convert.ToInt32(Console.ReadLine());
// Sum(result);



// Задача №3.1
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (upd: Пользователь вводит элементы массива в количестве 8)


// void Converter(int count)
// {
//     string str = "";

//     for (int i = 1; i <= count; i++)
//     {
//         Console.WriteLine($"Введите {i}-е число из {count}");
//         int num = Convert.ToInt32(Console.ReadLine());
//         str += $"{num} ";
//     }
//     Console.WriteLine();

//     string[] array = str.Split(' ');
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }

// Console.WriteLine("Введите размер массива");
// int num = Convert.ToInt32(Console.ReadLine());
// Converter(num);

// Задача №3.1 
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (upd: Пользователь вводит элементы массива в количестве 8)


// void Converter(int count)
// {
//     int[] arr = new int[0];

//     for (int i = 0; i < count; i++)
//     {
//         Console.WriteLine($"Введите {i + 1}-е число из {count}");
//         int num = Convert.ToInt32(Console.ReadLine());
//         arr = new int[] { num };
//     }
//     Console.WriteLine();


// }

// void PrintArray(int[] array)  // Павел, я хотел сделать другим способом, через PrintArray, но он у меня не выводится. Неделю кручу, не могу понять в чём дело?))
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     PrintArray(array);
// }

// Console.WriteLine("Введите размер массива");
// int count = Convert.ToInt32(Console.ReadLine());
// Converter(count);
