/*Напишите программу, в которой пользователь задает длину массива,
элементы которого задаются в диапазоне [1,99] и выводит на экран .
5 -> [1, 2, 5, 7, 19]
3 -> [6, 1, 33]*/

int ReadInt(string number)
{
    Console.Write(number);
    return Convert.ToInt32(Console.ReadLine());
}
int LengthArray = ReadInt("Введите длинну массива: ");

int[] randomArray = new int[LengthArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1, 99);
    //Console.Write(randomArray[i] + " ");
}
printArray(randomArray);
void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i < array.Length -1)
        {
        Console.Write(",");  
        }   
    }
    Console.WriteLine("]");
}