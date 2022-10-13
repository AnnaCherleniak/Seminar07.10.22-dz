// Написать программу вычисления произведения чисел от 1 до N.
Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine() ?? "0");
int sum = 1;
for(int i = 1; i <= N; i++)
{
    sum = sum*i;
}    
Console.WriteLine("Произведение чисел от 1 до N = " +sum);

