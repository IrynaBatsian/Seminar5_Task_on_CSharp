// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.


void InputArray(int[] array) // Процедура для заполнения массива
{
  for (int i = 0; i < array.Length; i++)
      array[i] = new Random().Next();   
}


string ReleaseArray(int[] array, int k)
{
  for (int i = 0; i < array.Length; i++) // Прохождение по массиву
  {
      if (array[i] == k)
        return "Yes";
  }
  return "No";
}  



Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n]; // Создаем сам массив в котором количество элементов = n.
InputArray(array); // Процедура заполнения нашего одномерного массива
Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]"); // Выводим заданный массив
Console.Write("Введите число, которое вы хотите найти в массиве: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ReleaseArray(array, k)); // Запускаем функцию, которая возвращает результат
