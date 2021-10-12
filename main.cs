using System;

class Program {
  public static void Main (string[] args) {
    

    double[] celcius = new double[7];
    for(int pos=0; pos < celcius.Length; pos++)
    {
      Console.WriteLine("Enter Temperature in Celcius");
      celcius[pos]=Convert.ToDouble(Console.ReadLine());
    }

    
    double[] fahrenheit = new double[7];
    for(int pos=0; pos < fahrenheit.Length; pos++)
    {
      fahrenheit[pos] = ((celcius[pos] * 9/5) + 32);
    }
    Array.Sort(fahrenheit);
    Array.Reverse(fahrenheit);
    Console.WriteLine("Temperature in Fahrenheit");
    foreach (double ftemp in fahrenheit)
    {
      Console.WriteLine(ftemp);
    }

    double sum = 0;
    foreach (double item in fahrenheit)
    {
      sum += item;
    }
    Console.Write("Average Weekly Temperature is ");
    Console.Write(sum/celcius.Length);
    Console.WriteLine(" Degrees Fahrenheit");
  }
}