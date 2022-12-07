// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

void InputArray(int[] array) // Процедура для заполнения массива
{
  for (int i = 0; i < array.Length; i++)
      array[i] = new Random().Next();   
}


void ReleaseArray(int[] array)
{
  for (int i = 0; i < array.Length; i++) // Прохождение по массиву
  array[i] *= (-1);
}  



Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n]; // Создаем сам массив в котором количество элементов = n.
InputArray(array); // Процедура заполнения нашего одномерного массива
Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]"); // Выводим заданный массив
ReleaseArray(array); // Запускаем процедуру
Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");