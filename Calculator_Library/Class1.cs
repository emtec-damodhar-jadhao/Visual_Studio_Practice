﻿namespace Calculator_Library
{
    public class Calculator_function
    {
        public static string Add(int n1,int n2)
        {
            return $"Addition of {n1} and {n2} is : {n1 + n2}";
        }

        public static string Sub(int n1, int n2)
        {
            return $"Subtraction of {n1} and {n2} is : {n1 - n2}";
        }

        public static string Multi(int n1, int n2)
        {
            return $"Multiplication of {n1} and {n2} is : {n1 * n2}";
        }

        public static string Div(int n1, int n2)
        {
            return $"Division of {n1} and {n2} is : {n1 / n2}";
        }
    }
}