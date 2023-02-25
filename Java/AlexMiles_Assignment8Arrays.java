package alexmiles_assignment8arrays;

public class AlexMiles_Assignment8Arrays {

	public static void main(String[] args) {
		
		// Author: Alex Miles
		
		int min = 1;
		int max = 100;
		int range = max - min + 1;
		int sum = 0;
		int[] randomArray = new int[1000];
		int[] countArray = new int[max];
		
		
		for (int i = 0; i < randomArray.length; i++)
		{ //initializing and randomizing the array
		  //I chose to set the index number of countArray as the number to be counted.
		  //The number inside the index is the amount of whatever number the index is so far.
	      //This way, I only have to use i and - i to count instead of copying numbers around.
		  
			randomArray[i] = (int) (Math.random() * range + min);
			if (randomArray[i] == 0)
			{ //checking to see if Math.random works.  I don't want zeros.
				System.out.println("Zero Detected.");
			} //if
			sum = (sum + randomArray[i]); //gathering the sum of all numbers in the array
			countArray[randomArray[i] - 1] = (countArray[randomArray[i] - 1] + 1); //where the magic happens
		} //for
		
		double average = ((double)sum / randomArray.length);
		System.out.println("The average of randomArray is: " + average); 
		//The average moves between 46 and 54, so I guess it worked.  Debug agrees with me too.
		
		for (int i = 1; i <= countArray.length; i++)
		{ //all I have to do is list the index and the number inside as the count.
			System.out.println("The number " + i + " appears " + countArray[i - 1] + " times.");
		} //for

	}//main

}//class
