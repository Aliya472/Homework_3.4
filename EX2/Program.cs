Console.WriteLine("Введите  число");  
int B= Convert.ToInt32(Console.ReadLine()); 
string A =B.ToString();  
int S=0, k=0; 
for( int i=0;i<A.Length;i++) 
{ 
    k=B%10;// остаток 
    S=S+k; 
    B=B/10; 
    } 
Console.WriteLine(S);