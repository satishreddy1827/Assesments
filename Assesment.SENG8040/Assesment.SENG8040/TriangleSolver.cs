using System;
using System.Collections.Generic;
using System.Text;

namespace Assesment.SENG8040
{
    public class TriangleSolver
    {
        /// <summary>
        /// Given the sides sideA, sideB, and sideC, determine and return the triangle type
        /// </summary>
        /// <param name="sideA">side A</param>
        /// <param name="sideB">side B</param>
        /// <param name="sideC">side C</param>
        /// <returns>The triangle type based on the sides passed in.</returns>
        public static string Analyze(int? sideA, int? sideB, int? sideC)
        {
            string messgae = string.Empty;

            if (checkValidity(sideA, sideB, sideC))
            {
                if (sideA == sideB && sideB == sideC)
                {
                    messgae = TriangleType.EquilateralTriangle;
                }

                else if ((sideA == sideB) || (sideA == sideC) || (sideB == sideC))
                {
                    messgae = TriangleType.IsoscelesTriangle;
                }

                else if ((sideA != sideB) && (sideA != sideC) && (sideB != sideC))
                {
                    messgae = TriangleType.ScaleneTriangle;
                }
            }
            else
            {
                messgae = TriangleType.NotTriangle;
            }

            return messgae;
        }
        private static bool checkValidity(int? a, int? b, int? c)
        {
            if (a + b > c || a + c > b || b + c > a)
                return true;
            else
                return false;
        }
    }
    /// <summary>
    /// Type of Triangle
    /// </summary>
    public static class TriangleType
    {
        public const string NotTriangle = "This is not a triangle.";
        public const string EquilateralTriangle = "This is an equilateral triangle.";
        public const string IsoscelesTriangle = "This is an isosceles triangle.";
        public const string ScaleneTriangle = "This is a scalene triangle.";
    }
}
