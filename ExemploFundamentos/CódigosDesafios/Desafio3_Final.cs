using System;
 
class Solution 
{
  public static void Main(string[] args) 
  {
    int n = int.Parse(Console.ReadLine());
    int c = 0;

    for (int i = 1; i <= n; i++) 
    {
        if (n % i ==  0   ) 
        {
            c++;
        }
    }
    if(c == 3)
    {
      Console.WriteLine(true);
    } else
    {
      Console.WriteLine(false);
    }
  }
}