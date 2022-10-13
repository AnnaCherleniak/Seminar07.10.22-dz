// Показать кубы чисел, заканчивающихся на четную цифру.

Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine() ?? "0");
for(int i = 2; i <= N; i= i+2)
{
    Console.WriteLine($"{i} ^3 = {i*i*i}");
}
