// // Задача 38: Задайте массив случайных вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

Console.WriteLine("Ведите размер массива");
int num = Convert.ToInt32(Console.ReadLine());
double[] array = new double[num];
NewArray(array);
PrintArray(array);
FindDiff(array);

void NewArray(double[] array)
{
    for (int i = 0; i < array.Length; i++) 
    array[i] = Convert.ToDouble(new Random().Next(10, 1000))/10;
}

void PrintArray(double[] array)
{
    foreach (double i in array)   
        Console.Write($"{i} ");
}

void FindDiff(double[] array)
{
double max = Int32.MinValue;
double min = Int32.MaxValue;

for (int j = 0; j < array.Length; j++)   //ищем мин и мах элементы
{
    if (array[j] > max)
    {
        max = array[j];
    }
    if (array[j] < min)
    {
        min = array[j];
    }
} 
double diff = max - min; 
Console.WriteLine();
Console.WriteLine($" MAX = {max}, MIN = {min} ");
Console.WriteLine($"Разница между мин и макс элементами массива = {Math.Round(diff,2)}");
}
