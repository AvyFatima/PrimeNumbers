using System;
					
public class Program
{
	public static void Main()
	{
		String fullSentence= "Remove this special char";
        char CharToremove = 'e';
		Method1(fullSentence,CharToremove);
		
		CharToremove = ' ';
		Method2(fullSentence,CharToremove);
		
        
	}
	
	public static void Method1( String fullSentence, char CharToremove){
		char[] allChars = fullSentence.ToCharArray();
        int i=0;
        foreach(char c in allChars){
            if(c != CharToremove)
               allChars[i] = c; 
            else
                allChars[i] = '\0';
                
            i++;
        }
        Console.WriteLine (allChars);
	}
	
	public static void Method2( String fullSentence, char CharToremove){
		char[] allChars = fullSentence.ToCharArray();
        String expectedSentence = "";
        foreach(char c in allChars){
            if(c != CharToremove)
               expectedSentence += c.ToString();
        }
        Console.WriteLine (expectedSentence);
	}
	
	
	
}
