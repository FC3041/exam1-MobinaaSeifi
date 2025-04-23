namespace Exam1;

class Program
{
    public class Q6Temperature
    {
    //    private static double _Celsius;
    //    public double Celsius { get { return _Celsius;} set { value = _Celsius; }}
                                                                

       
    //    private double _Fahrenheit;
    //    public double Fahrenheit { get { return _Fahrenheit;} set {   value = _Fahrenheit;}}
    //                                                                  Celsius = 9/5 * (Celsius- 32);}}
       
       public double Celsius {get; set;}
       public double Fahrenheit {get; set;}
       

       public Q6Temperature()
       {
        Fahrenheit = 1.8*Celsius + 32;
        // Celsius = 9/5 * (Fahrenheit - 32);
        }
    }
    static void Main(string[] args)
    {
        var temp = new Q6Temperature();
         temp.Celsius = 0.0;
         System.Console.WriteLine($"{temp.Celsius} , {temp.Fahrenheit}");
          temp.Fahrenheit = 212.0;
         System.Console.WriteLine($"{temp.Celsius} , {temp.Fahrenheit}");
 temp.Celsius = -40.0;
         System.Console.WriteLine($"{temp.Celsius} , {temp.Fahrenheit}");
temp.Fahrenheit = -40.0;
         System.Console.WriteLine($"{temp.Celsius} , {temp.Fahrenheit}");

        Console.WriteLine("Hello, World!");
    }
}
