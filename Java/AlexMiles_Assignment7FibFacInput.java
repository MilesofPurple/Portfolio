import java.util.Scanner;

public class AlexMiles_Assignment7Method {

	//Author: Alex Miles
	
	public static <CallFibOrFac> void main(String[] args) {
		
	Scanner input = new Scanner(System.in);	
		
	int fib = 10; //Left the number in, but still need to declare.
	int fac = 0;
	String FibFac;
	
	//Main Menu.  I'll challenge myself on the next assignment
	//and try to use cases instead of if-else, if possible.
	//I use "street talk" to match the theme of the assignment name.
	System.out.println("You wanna Fib or Fac?");
	FibFac = input.next(); {
	  if (FibFac.compareTo("Fib") == 0) {//Checking the input for "Fib".
		  System.out.println("\nHow many Fibs?");
		  fib = input.nextInt();
		  fib = (fib - 1);
		  System.out.println("0"); //I couldn't get the method to generate one zero.
		  for (int f = 1; f <= fib; f++) { //code kept crashing around here, I don't know how I fixed it.
		  	System.out.println(fibonacci(f)); 
		  }
	  }
		
	  if (FibFac.compareTo("Fac") == 0) { //Checking the input for "Fac".
		  System.out.println("\nWhat's the Facs?");
		  fac = input.nextInt();
		  System.out.println("\nThe fac of " + fac + " is: " + factorial(fac) + ".  Right on!");
	  }
	  
	  if ((FibFac.compareTo("Fac") & FibFac.compareTo("Fib")) != 0) {
		  System.out.println("See ya, man.");
	  }
	}
}
		
	public static int fibonacci(int fib) {
		if (fib == 0) {
			return 0;
		}     else if (fib == 1) {
			    return 1;
		}         
		          else {
		            return fibonacci(fib - 1) + fibonacci(fib - 2);
		}
	}
	
	public static int factorial(int fac) {
		if (fac == 0) {
			return 1;
			}
		      else {
			    return fac * factorial(fac - 1);
		}
	}
}



