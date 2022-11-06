Console.WriteLine("Введите кол-во элементов");
int N= Convert.ToInt32(Console.ReadLine());
int [] A= new int[N];
for( int i=0; i<A.Length;i++)
{
    A[i]= new Random().Next(1,100);
    Console.Write(A[i] +" ");
}