// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

void InputArray(int[] array) // Процедура для заполнения массива
{
  for (int i = 0; i < array.Length; i++)
      array[i] = new Random().Next(0, 11);   
}


void ReleaseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2 + array.Length % 2; i++)
        Console.Write($"{array[i] * array[array.Length - i - 1]} ");
  }  



Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n]; // Создаем сам массив в котором количество элементов = n.
InputArray(array); // Процедура заполнения нашего одномерного массива
Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]"); // Выводим заданный массив
ReleaseArray(array);