using System;

namespace ConsoleApp1
{
  class Program
  {
    static void Main(string[] args)
    {
      for(int i=0; i < 100; i++)
      {
        Console.Beep(2200-i*20, 300-2*i);
        Console.WriteLine("ya ne konchenniy!");
        
      }
      Console.Beep(3000, 40000);
    }
  }
}
