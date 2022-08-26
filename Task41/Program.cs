//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел, которое будете вводить: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] GreateArray(int num)
{
    int[] array = new int[num];
    
    for (int i = 0; i < num; i++)
    {
        Console.Write($"Число №{i+1} = ");
        array[i] = Convert.ToInt32(Console.ReadLine()); 
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
         if (i == 0) Console.Write($"[{array[i]},");
         else if (i < array.Length-1) Console.Write($"{array[i]},");
         else Console.Write($"{array[i]}]");
    }     
}

int Count(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
} 

int[] arr = GreateArray(number);
PrintArray(arr);
int result = Count(arr);
Console.Write($" -> {result}");
