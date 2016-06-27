using System.Collections.Generic;

namespace Triangles.Objects
{
  public class Triangle
  {
    private int _base;
    private int _height;
    private int _hypotenuse;

    public Triangle(int side1, int side2, int side3)
    {
      List<int> sideList = new List<int> {side1,side2,side3};
      sideList.Sort();
      _base = sideList[0];
      _height = sideList[1];
      _hypotenuse = sideList[2];
    }

    public string GetTriangleType()
    {
      if (_base + _height <= _hypotenuse) return "That's not a triangle.";
      else if (_base == _hypotenuse) return "Your triangle is equilateral.";
      else if (_base == _height) return "That is an isosceles triangle.";
      else return "That is a scalene triangle.";
    }

    public int GetArea()
    {
      return _base * _height / 2;
    }

    public int GetBase()
    {
      return _base;
    }

    public int GetHeight()
    {
      return _height;
    }

    public int GetHypotenuse()
    {
      return _hypotenuse;
    }

  }
}
