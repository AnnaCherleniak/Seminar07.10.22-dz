// Найти кубы чисел от 1 до N.
Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine() ?? "0");
for(int i = 1; i <= N; i++)
{
    Console.WriteLine($"{i} ^3 = {i*i*i}");
}
