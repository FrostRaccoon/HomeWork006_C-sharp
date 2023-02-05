/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.WriteLine("Введите числа через пробел: ");
string[] nums = Console.ReadLine().Split(' ');
Console.WriteLine($"Кол-во чисел больше 0 -> {NumsAboveZero(nums)}");

int NumsAboveZero(string[] arr)
{
    int numsAbove = 0;
    foreach (string element in arr)
    {
        if(Convert.ToInt32(element) > 0)
        {
            numsAbove += 1;
        }
    }
    return numsAbove;
}