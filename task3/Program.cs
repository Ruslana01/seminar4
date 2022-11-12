// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int Read(string text) 
{
    Console.Write(text);
    return int.Parse(Console.ReadLine()!);
}
int ArrayLenght = Read("Введите длинну массива: ");
int[] random_array = new int[ArrayLenght];
for (int i = 0; i < random_array.Length; i++)
{
    random_array[i] = new Random().Next(1, 100);
    Console.Write(random_array[i] + " ");
}