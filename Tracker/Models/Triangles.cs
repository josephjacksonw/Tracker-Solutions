namespace Triangle
{
  public class Checker
  {
    public bool IsTriangle(int side1, int side2, int side3)
    {
      // logic will go here
      if (side1 > side2+side3 || side2 > side1+side3 || side3 > side2+side1)
      {
        return false;
      }
      else
      {
        return true;
      }
    }
    public string checkType(int side1, int side2, int side3)
    {  
      if (side1 == side2 && side2 == side3) 
      {
        return "This is an equilateral triangle!";
      }
      else if (side1 == side2 || side2 == side3 || side1 == side3)
      {
        return "This is an isosceles triangle!";
      }
      else 
      {
        return "This is a scalene triangle!";
      }
    }
  }
}