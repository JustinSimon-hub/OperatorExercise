namespace OperatorExercise
{
    public class Program
    {






       public static void Main(string[] args)
        {
 int a = 17;
 int b = 4;

 int q = a/b;
 int r = a%b;
Console.WriteLine($"{a} / {b} is {q} remainder {r}"); 
//end of exercise 1

Console.WriteLine("What is the radius?");

 
  double radius = double.Parse(Console.ReadLine());
double AreaOfCircle = Math.PI * (radius * radius);

 
 
 Console.WriteLine($"The area of the circle with a radius of {radius} is {AreaOfCircle}");
 }







    }


}
