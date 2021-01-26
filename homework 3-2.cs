
using System;
					
public class Program
{
	public static void Main()
	{
			// 1
		int a = Convert.ToInt32(Console.ReadLine());
		int b = Convert.ToInt32(Console.ReadLine());
		int sum = 0;
		Console.WriteLine("The odd numbers");
		for (int i = a+1;i<b;i++){
			sum += i;
			if (i%2!=0){
				Console.WriteLine(i);
			}
		}
		Console.WriteLine("The summ of numbers");
		Console.WriteLine(sum);
		//2
		int len = 20;
		int len2 = 0;
		for (int d= 0;d<len;d++){
				  Console.Write(" ");
			  }
		for (int i = 0;i < 46;i++){
			if (i < 20){
			Console.Write("*");
			}else if (i<26){
				
				Console.Write("\n");
				for (int d= 0;d<len;d++){
				  Console.Write(" ");
			  }
				Console.Write("*");
				Console.Write("                  "+"*");
			}
		}
			Console.Write("\n");
		    for (int j= 0;j < 20;j++){
				  Console.Write(" ");
			}
			for (int j= 0;j < 20;j++){
				  Console.Write("*");
			}
			Console.Write("\n");
			Console.Write("\n");
			for (int j= 0;j < 10;j++){
			  Console.Write("\n");
			  for (int d= 0;d<len;d++){
				  Console.Write(" ");
			  }
			  Console.Write("*");
			  for (int d= 0;d<j;d++){
				  Console.Write(" ");
			  }
			  Console.Write("*");
		  }
			Console.Write("\n");
		    for (int j= 0;j < 20;j++){
				  Console.Write(" ");
			}
			for (int j= 0;j < 12;j++){
				  Console.Write("*");
			}
		    Console.Write("\n");
			Console.Write("\n");
			for (int j= 0;j < 10;j++){
			  for (int d= 0;d<len;d++){
				  Console.Write(" ");
			  }
			  Console.Write("*");
			  for (int d= 0;d<len2;d++){
				  Console.Write(" ");
			  }
			  Console.Write("*");
				Console.Write("\n");
				len --;
				len2+=2;
		  }
			
			for (int j= 0;j < 10;j++){
				  Console.Write(" ");
			}
			for (int j= 0;j < 20;j++){
				  Console.Write("*");
			}
		 Console.Write("\n");
		 Console.Write("\n");
		 len = 20;
		 len2 = 0;
		for (int j= 0;j < 8;j++){
			  for (int d= 0;d<len;d++){
				  Console.Write(" ");
			  }
			  Console.Write("*");
			  for (int d= 0;d<len2;d++){
				  Console.Write(" ");
			  }
			  Console.Write("*");
				Console.Write("\n");
				len -=2;
				len2+=4;
		  }
		for (int j= 0;j < 9;j++){
			  for (int d= 0;d<len;d++){
				  Console.Write(" ");
			  }
			  Console.Write("*");
			  for (int d= 0;d<len2;d++){
				  Console.Write(" ");
			  }
			  Console.Write("*");
				Console.Write("\n");
				len +=2;
				len2-=4;
		  }
		//3
		   Random sum   = new Random();
		double percent = sum.Next(0,25);
		double first_deposit = 1000;
		int mounth;
		Console.WriteLine(percent);
		for (mounth = 1; first_deposit<1100;mounth++) {
			first_deposit = (first_deposit+(first_deposit*percent)/100 );
			
		}
		Console.WriteLine(mounth);
			Console.WriteLine(first_deposit);
			
          }
      }
	