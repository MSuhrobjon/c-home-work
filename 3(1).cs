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
     int a = Convert.ToInt16(Console.ReadLine());
     int b = Convert.ToInt16(Console.ReadLine());
              if(a==b) {
              a = b = 0;
              Console.WriteLine(a);
              Console.WriteLine(b);
          } else {
              a = a + b;
              b = b + a;
              Console.WriteLine(a);
              Console.WriteLine(b);
          }
    // I have not problem
    // 2
    int operand1 = Convert.ToInt16(Console.ReadLine());
    int operand2 = Convert.ToInt16(Console.ReadLine());
    char sing = Convert.ToChar(Console.ReadLine());
    switch (sing){
        case '+':
          Console.WriteLine(operand1+operand2);
          break;
        case '-':
          Console.WriteLine(operand1-operand2);
          break;
        case '/':
           if (operand2 == 0){
               Console.WriteLine("We can not devide in zero");
           } else {
          Console.WriteLine(operand1/operand2);
           }
          break;
        case '*':
          Console.WriteLine(operand1*operand2);
          break;
        case '%':
          Console.WriteLine(operand1%operand2);
          break;
        default:
            Console.WriteLine("Input correct value");
            break;
    }
    //I have not problem
    // 3
    int operand = Convert.ToInt16(Console.ReadLine());
    if (operand >= 0 && operand <= 14){
        Console.WriteLine("In interval [14-0] the number is related");
    } else if (operand >= 15 && operand <= 35){
        Console.WriteLine("In interval [15-35] the number is related");
        
    } else if (operand >= 26 && operand <= 50){
        Console.WriteLine("In interval [26-50] the number is related");
        
    } else if (operand >= 50 && operand <= 100){
        Console.WriteLine("In interval [50-100] the number is related");
        
    } else {
        Console.WriteLine("In none of interval  the number related");
        
    }
    
    

  }
}