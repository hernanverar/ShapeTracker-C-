using System;
using ShapeTracker.Models; // can run with or without but this is the corret way.

namespace ShapeTracker
{
  class Program
  {
    static void Main()
    {
      ShapeTracker.Models.Triangle testTriangle = new ShapeTracker.Models.Triangle();
      Console.WriteLine(testTriangle.GetType());
    }
  }
}