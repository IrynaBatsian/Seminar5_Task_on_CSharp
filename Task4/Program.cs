//  Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]



void InputArray(int[] array) // Процедура для заполнения массива
{
  for (int i = 0; i < array.Length; i++)
      array[i] = new Random().Next(-100, 100);   
}


int ReleaseArray(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++) // Прохождение по массиву
  {
      if (array[i] >=10 && array[i] <= 99)
        count++;
  }
  return count;
  
}  



Console.Clear();
int[] array = new int[123]; // Создаем сам массив в котором количество элементов = n.
InputArray(array); // Процедура заполнения нашего одномерного массива
Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]"); // Выводим заданный массив
Console.WriteLine($"Результат: {ReleaseArray(array)}");
