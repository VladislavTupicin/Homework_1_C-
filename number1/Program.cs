Console.Clear();
Console.WriteLine("Первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

int max = a;

if (a > max) max = a;
if (b > max) max = b;

Console.Write("max = ");
Console.WriteLine(max);