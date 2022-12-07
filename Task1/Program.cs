// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9,9]. Найдите сумму отрицательных и положительных элементов массива.

 
 void InputArray(int[] array) // Процедура для заполнения массива
{
  for (int i = 0; i < array.Length; i++)
      array[i] = new Random().Next(-9, 10);   
}


void ReleaseArray(int[] array)
{
  int sumPositive = 0, sumNegative = 0;
  for (int i = 0; i < array.Length; i++) // Прохождение по массиву
  {
      if (array[i] > 0)
          sumPositive += array[i];
      else 
          sumNegative += array[i];
  } 
  Console.WriteLine($"Сумма положительных чисел в массие {sumPositive}");
  Console.WriteLine($"Сумма отрицательных чисел в массие {sumNegative}");
}


Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n]; // Создаем сам массив в котором количество элементов = n.
InputArray(array); // Процедура заполнения нашего одномерного массива
Console.WriteLine($"[{string.Join(", ", array)}]"); // Выводим заданный массив
ReleaseArray(array); // Запускаем процедуру