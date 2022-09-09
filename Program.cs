/* Task : Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символам. Первоночальный массив можно ввести с клавиатуры,
 либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
  лучше обойтись исключительно массивами.
*/
string[] FirstArray(int size)
{
    string[] firstarray = new string[size];
    for ( int i = 0; i < firstarray.Length; i++)
    {
        Console.Write($"Введите {i + 1} строку: ");
        firstarray[i] = Console.ReadLine();
    }
    return firstarray;
}
void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");

Console.WriteLine();
}
string[] NewArray(string[] firstarray)
{
    int length = 0;
    int count = 0;
    for (int i = 0; i < firstarray.Length; i++)
    {
        length = firstarray[i].Length;
        if (length < 4)
        {
            count++;
        }
    }
    string[] newarray = new string[count];
    count = 0;
    for (int i = 0; i < firstarray.Length; i++)
    {
        length = firstarray[i].Length;
        if(length < 4)
        {
            newarray[count] = firstarray[i];
            count++;
        }
    }
    return newarray;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] firstarray = FirstArray(size);
string[] newarray = NewArray(firstarray);
Console.WriteLine(" Изначальный массив: ");
ShowArray(firstarray);
Console.WriteLine("Полученный массив: ");
ShowArray(newarray);