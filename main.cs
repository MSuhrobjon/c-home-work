/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
      // 1
            double first_num = 16.80;
            double second_num = 12.40;
            double result = Math.Sqrt(first_num*second_num);
            Console.WriteLine(result);
            // 2
            double a = 1.40;
            double b = -5.50;
            double c = 0.60;
            double ac = Math.Abs(a - c);
            double bc = Math.Abs(c - b);
            Console.WriteLine(ac + bc);
            // 3
            double x1 = -6.20 , y1 = 5.20 ;
            double x2 = 2.10, y2 = 9.80;
            double result1 = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2));
            Console.WriteLine(result1);
            // 4
            int num = 41;
            int elem1 = num % 10;
            int elem2 = num / 10;
            Console.WriteLine(elem1*10+elem2);    
            // 5
            double n = 10985;
            Console.WriteLine((n%(3600*60))/60);
            // 6
            double k = 202;
            double week = k%7;
            Console.WriteLine(week);
  }
}