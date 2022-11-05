Console.WriteLine("Введите первое число");
int A =Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите второе число");
int B= Convert.ToInt32(Console.ReadLine());
int S=1;
for( int k=1; k<=B; k++)
{
S=S*A;
}
Console.WriteLine(S);