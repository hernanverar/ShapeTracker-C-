using System;
using ShapeTracker.Models; // can run with or without but this is the corret way.

namespace ShapeTracker
{
  public class Program
  {
    static void Main()

    {
    
    Triangle testTriangle = new Triangle(3, 4, 5);
    Console.WriteLine($"Side one of the triangle: {testTriangle.Side1}");
    Console.WriteLine($"Side one of the triangle: {testTriangle.Side2}");
    Console.WriteLine($"Side one of the triangle: {testTriangle.Side3}");
    Console.WriteLine("Want to know what type of triangle you have?");
    Console.WriteLine("Calculating...");
    Console.WriteLine($"Your triangle is: {testTriangle.Checktytpe()}.");
    }
  }
}
