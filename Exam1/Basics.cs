using System.Security.Cryptography.X509Certificates;

namespace Exam1;
public class Q1_Add
{
    public static int a { get; set;}
    public static int b {get; set;}
    public Q1_Add(int aa, int bb)
    {
        a = aa;
        b = bb;
    }
    public static int Add(int a, int b)
    {
        return a+b;
    }
}
public class Basics
{
    public static int a { get; set;}
    public static int b {get; set;}
    public Basics(int aa, int bb)
    {
        a = aa;
        b = bb;
    }
    public static void Q2MultiplyAndReset(ref int a, ref int b)
    {
        a = a*b;
        b = 1;
    }
}

public class Q4Person
{
    public string Name {get; set;}
    public int Age {get; set;}
    public Q4Person( string nname, int aage)
    {
        Name = nname;
        Age = aage;
    }
    public string Introduce()
    {
        return $"Hello, my name is {Name} and I am {Age} years old.";
    }
    
    
}
// // public class Q6Temperature
// //     {
//     //    private static double _Celsius;
//     //    public double Celsius { get { return _Celsius;} set {     value = _Celsius;
//     //                                                              Fahrenheit = 32 + 1.8*_Celsius;}}

       
//     //    private double _Fahrenheit;
//     //    public double Fahrenheit { get { return _Fahrenheit;} set {   value = _Fahrenheit;
//     //                                                                  Celsius = 9/5 * (Celsius- 32);}}
       
//        public double Celsius {get; set;}
//        public double Fahrenheit {get; set;}
       

//        public Q6Temperature()
//        {
//         this.Fahrenheit = 1.8*Celsius + 32;
//         this.Celsius = 9/5 * (Fahrenheit - 32);
//         }
//     }
public interface IShape
    {
        public double GetArea();
        public double GetPerimeter();
    }
    
    public class Q7Circle : IShape
    {
        public double R {get; set;}
        public Q7Circle(double r)
        {
            R = r;
        }
        public double GetArea()
        {
            return Math.PI*R*R;
        }
        public double GetPerimeter()
        {
            return 2*Math.PI*R;
        }

    }
    public class Q7Rectangle : IShape
    {
        public double W {get; set;}
        public double L{get; set;}

        public Q7Rectangle(double w, double l)
        {
            W = w;
            L = l;

        }
        public double GetArea()
        {
            return L*W;
        }
        public double GetPerimeter()
        {
            return 2*(L + W);
        }

    }
    public static class ShapeUtils
    {
        public static double Q7TotalArea(IShape[] shapes)
        {
            double t = 0;
            
            for(int i=0; i<shapes.Length; i++)
            {
                t += shapes[i].GetArea();
            }
            return t;
        }
    }
    

   
