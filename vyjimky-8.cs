using System;

public class Program
{
	public static char[] Deduplicate(char[] chArr){
		char[] newChArr = new char[chArr.Length];
		
		for (int i = 0; i < chArr.Length; i++){
			for (int j = 0; j < chArr.Length; j++){
				if (chArr[i] != newChArr[j]){
					for (int k = 0; k < chArr.Length; k++){
						if (newChArr[k] == '\0'){
							newChArr[k] = chArr[i];
							break;
						}
					}	
				}
			}			
		}
		return newChArr;
	}
	
	public static void Main()
	{
		char[] chArr = {'A', 'a', 'j', 'a', 'e', 'E', 'J', 'a', 'e'};
		char[] newChArr = Deduplicate(chArr);

		for (int i = 0; i < chArr.Length; i++){
			Console.Write(newChArr[i]);			
		}
	}
}
