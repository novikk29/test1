Console.Clear();
string[] array1 = new string[6] {"hello","2","world",":-)","abc","777"};
string[] array2 = new string[array1.Length];
void SortedArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void printArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i < array.Length - 3)
        {
        Console.Write(", ");
        }
    }
    Console.Write(" ]");
}
Console.Write($"Строки из заданного массива, состоящие не более, чем из 3-х символов: ");
SortedArray(array1, array2);
printArray(array2);
Console.WriteLine();
