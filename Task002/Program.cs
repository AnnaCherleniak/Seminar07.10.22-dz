// Подсчитать сумму цифр в числе.

Console.Write("Введите число N - ");
string N = Convert.ToString(Console.ReadLine() ?? "0");
int sum = 0;
for(int i = 0; i<N.Length; i++)
{
    sum += Convert.ToInt32(N[i].ToString());
}
Console.WriteLine(sum);