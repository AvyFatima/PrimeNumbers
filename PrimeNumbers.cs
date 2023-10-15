using System;
					
public class Program
{
	public static void Main()
	{
		string primeList = "";
    //Prime Numbers till 1000 
		int n =1000;
    //Starting with First Prime Number
		int i =2;
		while(i<n){
			bool isPrimeNum = true;
			for(int j=2;j<i;j++){
				if(i%j==0){
					isPrimeNum = false;
				}
			}
			if(isPrimeNum)
			{
				primeList += ","+ i;	
			}
			i++;
		}
        //Gives entire list of Prime Numbers within n number.
        Console.WriteLine(primeList.TrimStart(','));
	}
	
	
	
}
