using System;
					
public class Program
{
	public static void Main()
	{
		// 1
		Random rnd = new Random();
		int n= Convert.ToInt32(Console.ReadLine());
		int[] numb= new int[n];
		for (int i = 0; i < n;i++){
		
			numb[i] = rnd.Next(0,100);
		}
		foreach(int elem in numb ){
			Console.WriteLine(elem);
		}
		 Array.Sort(numb);
		Console.WriteLine(numb[n-1]);
		Console.WriteLine(numb[0]);
		double sum = 0;
		foreach(int elem in numb ){
			sum += elem;
		}
		Console.WriteLine(sum);
		Console.WriteLine(sum/n);
		foreach(int elem in numb ){
			if(elem%2!=0){
				Console.WriteLine(elem);
			}
		}
		//2
		Console.WriteLine("Input size of array: ");
		int val = Convert.ToInt32(Console.ReadLine());
		int[] N = new int[val];
			for (int i = 0; i < val ;i++) {
				Console.WriteLine("Input number "+i+" :");
				int number = Convert.ToInt32(Console.ReadLine());
				N[i] = number;
			}
		Array.Sort(N);
		Array.Reverse(N);
		foreach(int i in N){
			Console.WriteLine(i);`
		}  
		// 3
		Console.WriteLine("Input size of array: ");
		int num = Convert.ToInt32(Console.ReadLine());
		int[] arr = new int[num];
			for (int i = 0; i < num ;i++) {
				Console.WriteLine("Input number "+i+" :");
				int number = Convert.ToInt32(Console.ReadLine());
				arr[i] = number;
			}
		foreach(int i in arr){
			Console.WriteLine(i);
		}
		int count = Convert.ToInt32(Console.ReadLine());
		int index = Convert.ToInt32(Console.ReadLine());
		int[] new_arr = new int[count];
		int index_elem = index;
		for (int j= 0; j < count ;j++){
			if (index < num){
				new_arr[j] = arr[index];
				index++;
			} else {
				new_arr[j] = 1;
			}
			
		}
		foreach(int i in new_arr){
			Console.WriteLine(i);
		}
          }
      }
	