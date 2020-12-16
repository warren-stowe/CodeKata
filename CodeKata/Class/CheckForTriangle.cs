using System;
using System.Collections.Generic;
using System.Text;

namespace CodeKata.Class
{
    public static class CheckForTriangle
    {
        //Implement a method that accepts 3 integer values a, b, c. The method should return true if a triangle can be built with the sides of 
        // given length and false in any other case.
        public static bool IsTriangle(int side1, int side2, int side3)
        {
            return (((side1 + side2) > side3) && ((side2 + side3) > side1) && ((side1 + side3) > side2));
        }
    }
}
