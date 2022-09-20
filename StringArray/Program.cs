/* Написать программу, которая из имеющегося массива строк
 формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
*/

Console.Write("Введите количество элементов массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());

string[] GetArray(int size)
{
    string[] fillArray = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        fillArray[i] = Console.ReadLine();
    }
    return fillArray;
}
void FinalArray(string[] array)
{
    string[] selectArray = new string[array.Length];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
        {
            selectArray[j] = array[i];
            j++;
        }
    for (int k = 0; k < j; k++)
    {
        if (k < j - 1)
            Console.Write(selectArray[k] + ", ");
        else Console.Write(selectArray[k]);
    }
}

string[] newArray = GetArray(arraySize);
Console.WriteLine("Элементы массива, длина которых меньше или равна 3 символам: ");
FinalArray(newArray);
