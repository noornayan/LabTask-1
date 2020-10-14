﻿using System;


namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1. Write a program to print 'Hello' on screen and then print your name on
            a separate line.*/
            Console.WriteLine("Hello");
            Console.WriteLine("Nayan");

            //2. Write a program to print the sum of two numbers.
            int a = 20;
            int b = 5;
            int c = a + b;
            Console.WriteLine("add : " + c);

            //3.Write a program to divide two numbers and print on the screen.
            double d = a / b;
            Console.WriteLine("div : " + d);

            /*4. Write a program to print the result of the following operations.
            Data:
            a. -5 + 8 * 6
            b. (55+9) % 9
            c. 20 + -3*5 / 8
            d. 5 + 15 / 3 * 2 - 8 % 3 */ 

            double xa = -5 + 8 * 6;
            Console.WriteLine("result a : " + xa);
            double xb = (55 + 9) % 9;
            Console.WriteLine("result b : " + xb);
            double xc = 20 + -3 * 5 / 8;
            Console.WriteLine("result c : " + xc);
            double xd = 5 + 15 / 3 * 2 - 8 % 3;
            Console.WriteLine("result d : " + xd);

            /*5. Write a program to print the sum (addition), multiply, subtract, divide
            and remainder of two numbers.*/
            int k = 30;
            int l = 10;
            int addition = k + l;
            double multiply = k * l;
            double subtract = k - l;
            double divide = k / l;
            double remainder = k % l;
            Console.WriteLine("result addition : " + addition);
            Console.WriteLine("result multiply : " + multiply);
            Console.WriteLine("result subtract : " + subtract);
            Console.WriteLine("result divide : " + divide);
            Console.WriteLine("result remainder : " + remainder);

            /*6.Write a program to compute the specified expressions and print the
            output.
            Expression:
            ((25.5 * 3.5 - 3.5 * 3.5) / (40.5 - 4.5))*/
            double cal = ((25.5 * 3.5 - 3.5 * 3.5) / (40.5 - 4.5));
            Console.WriteLine("calculation : " + cal);

            /*7.Write a program to print the area and perimeter of a rectangle.
            Data:
            Width = 5.5 Height = 8.5
            Sample Output:
            Area is 5.6 * 8.5 = 47.60
            Perimeter is 2 * (5.6 + 8.5) = 28.20*/
            double width = 5.5;
            double height = 8.5;
            double area = width * height;
            double perimeter = 2 * (width + height);
            Console.WriteLine("Area is " + width + "*" + height + " = " + area);
            Console.WriteLine("Perimeter is 2 * (" + width + "+" + height + ") = " + perimeter);
        }
    }
}

