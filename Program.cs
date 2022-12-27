// Написать программу, которая из имеющегося массива строк 
//формирует массив из строк, длина которых меньше либо равно 3 символа.
//Первоначальный массив можно ввести с клавиатуры, лио задать на старте 
//выполнения алгоритма. 

string[] ArrayFirst(int size=5)
{
  string[] a=new string[size];
  for(int i=0;i<size;i++)
  {
    a[i]=System.Console.ReadLine();
  }
  return a;
}

string[] ArraySecond(string[] a)
{
  int count=0;
  string[] b=new string[a.Length];
  for(int i=0;i<a.Length;i++)
  {
    if (a[i].Length<=3)
    {
      b[count]=a[i];
      count++;
    }
  }
  return b;
}

void Print1(string[] a)
{
  for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],10}");
}    

void Print2(string[] b)
{
  for(int i=0;i<b.Length;i++)
    System.Console.Write($"{b[i],10}");
} 

string[] a=ArrayFirst();
Print1(a);
string[] b=ArraySecond(a);
System.Console.WriteLine();
Print2(b);
