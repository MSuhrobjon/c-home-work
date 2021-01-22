/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
      // 1 home-work 3.2
      int cost = Convert.ToInt32(Console.ReadLine());
      if (cost >= 500){
        Console.WriteLine((cost*97)/100);
      } else if (cost >= 1000) {
          Console.WriteLine((cost*95)/100);
      }  else {
          Console.WriteLine(cost);
      }
      // I have not problem
      // 2 
      int first = Convert.ToInt32(Console.ReadLine());
      int second = Convert.ToInt32(Console.ReadLine());
      int third = Convert.ToInt32(Console.ReadLine());
      int fourth = Convert.ToInt32(Console.ReadLine());
      if (first == second && third == fourth && first == fourth){
            Console.WriteLine(Math.Pow(first,4));
      } else if (first < second  && second < third && third < fourth) {
            Console.WriteLine("The growing sequence");
      } else {
          int elem1 = Math.Min(first,second);
          int elem2 = Math.Min(third,fourth);
          if (elem1 < elem2){
              Console.WriteLine("The min element is "+elem1);
              
          } else if(elem1 > elem2) {
              Console.WriteLine("The min element is "+elem2);
          } else {
              Console.WriteLine("The mins element are " + elem1);
          }
      }
      
      // 3 
       int first_elem = Convert.ToInt32(Console.ReadLine());
      int second_elem = Convert.ToInt32(Console.ReadLine());
      int third_elem = Convert.ToInt32(Console.ReadLine());
      int[] numbers = new int[3] {first_elem,second_elem,third_elem};
      Array.Sort(numbers);
      for (int i = 0; i < 4;i++){
         Console.WriteLine(' '+numbers[i]);
      }
      
  }
}