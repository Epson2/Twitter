using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Please enter message: ");
    Console.WriteLine();
    string userText = Console.ReadLine();
    Console.WriteLine();

    if (userText.Length <= 140) 
    {
      Console.WriteLine("Posted");
    }
    else
    {
      Console.WriteLine("Regected");
    }
  }
}