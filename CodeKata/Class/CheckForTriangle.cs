using System;
using System.Collections.Generic;
using System.Text;

namespace CodeKata.Class
{
    public static class CheckForTriangle
    {
        public static bool IsTriangle(int side1, int side2, int side3)
        {
            if (((side1 + side2) > side3) && ((side2 + side3) > side1) && ((side1 + side3) > side2))
            {
                return true;
            }

            return false;
        }
    }
}
