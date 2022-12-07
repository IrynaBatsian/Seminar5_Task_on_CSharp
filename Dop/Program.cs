// Дополнительная задачу суперсдвиг. Пользователь задает длину массива, сам массив и "K" на сколько символов сделать сдвик. Если К положительно, то вправо, а если отрицательно, то влево

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int[] arrayHelp = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine("Введите число сдвига: ");
int k = Convert.ToInt32(Console.ReadLine());
k = k % n; // для того, чтобы не делать лишние ненужные сдвиги  
if (k > 0)
{
  for (int i = 0; i < k; i++)
      arrayHelp[i] = array[array.Length - k + i];
  for (int i = 0; i < array.Length - k; i++)
      arrayHelp[k + 1] = array[i];

  Console.WriteLine($"[{string.Join(", ", arrayHelp)}]");   
}  
else
{
  k = (-1)* k;
  for (int i = 0; i < k; i++)
      arrayHelp[array.Length -k + i] = array[i];
  for (int i = 0; i < array.Length -k; i++)
      arrayHelp[i] = array[k + 1];
  Console.WriteLine($"[{string.Join(", ", arrayHelp)}]");
}