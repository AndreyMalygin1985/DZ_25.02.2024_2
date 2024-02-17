// Пользователь вводит с клавиатуры два числа. Первое число — это значение,
// второе число процент, который необходимо посчитать. Например, мы ввели с клавиатуры 90 и 10.
// Требуется вывести на экран 10 процентов от 90. Результат: 9.
class Program
{
    static void Main()
    {
        Console.WriteLine("Вычислим процент от числа.");
        Console.WriteLine("Введите первое число:");
        double number = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите второе число (процент):");
        double percent = Convert.ToDouble(Console.ReadLine());

        double result = (number * percent) / 100;
        Console.WriteLine("Результат: " + result);
    }
}