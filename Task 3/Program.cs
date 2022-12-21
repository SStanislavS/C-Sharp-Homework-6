// Найдите сумму произведений пар чисел в одномерном целочисленном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Console.Write("Введите с клавиатуры числа (через пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int sum = 0;

for (int i = 0; i <arr.Length / 2; i++)
{
     sum += arr[i] * arr[arr.Length - 1 - i];
}
 
Console.WriteLine("Сумма произведений пар чисел: " + sum);
 