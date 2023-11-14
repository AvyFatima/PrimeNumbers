using System;
					
public class Program
{
	public static string[] units = new string[]{"zero","one","two","three","four","five","six","seven","eight","nine","ten","eleven","twelve","thirteen","fourteen","fifteen","sixteen","seventeen","eighteen","nineteen"}; 
	public static string[] tens = new string[]{"","","twenty","thirty","fourty","fifty","sixty","seventy","eighty","ninety"};
	public static void Main()
	{
		//write any number to convert to words
		int num= 993450;
		string result = ToWords(num);
		Console.WriteLine(result);
	}
	
	public static string ToWords(int i){
		String words = "";
		if(i<20)
			words = units[i];
		else if(i<100)
			words = tens[i/10]+ " " + ToWords(i%10);
		else if(i<1000)
			words = units[i/100]+ " hundred " + ToWords(i%100);
		else if(i<20000)
			words = units[i/1000]+ " thousands " + ToWords(i%1000);
		else if(i<100000)
			words = tens[i/10000]+ " " + units[i/10000]+ " thousands " + ToWords(i%1000);
		else if(i<1000000)
			words = units[i/100000]+ " hundred " + ToWords(i%100000);
		else if(i<20000000)
			words = units[i/1000000]+ " millions " + ToWords(i%1000000);
		else if(i<100000000)
			words = tens[i/10000000]+ " " + units[i/10000000]+ " millions " + ToWords(i%1000000);
		
		return words;
	}
}
