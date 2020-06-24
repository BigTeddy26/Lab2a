using System;

class MainClass {
  public static void Main (string[] args) {
  Console.WriteLine ("Please insert the temperature in Celsius.");

    int celsius, Fahrenheit;
           
            celsius = int.Parse(Console.ReadLine());
            Fahrenheit = (celsius * 9) / 5 + 32;
            Console.WriteLine("Temperature in Fahrenheit is " + Fahrenheit);

        if (Fahrenheit <= 212)

        {
          Console.WriteLine("The Celsius is below freezing of 32 degree Farenheit");
        }

      if (Fahrenheit >= 32)

      {
        Console.WriteLine("The Celsius is above boiling point of 212 degree Farenheit");
      }
 
    
  }
}