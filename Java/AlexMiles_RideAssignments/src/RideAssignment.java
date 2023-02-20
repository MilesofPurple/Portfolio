import java.util.Scanner;

public class RideAssignment {

	private static Scanner input;

	public static void main(String[] args) {
		
		Scanner input = new Scanner(System.in);
		  

		int age = 0;
		int weight = 0;
		boolean isNumber;
		
		do {
			System.out.print("Please enter your age (in years):");
			if (input.hasNextInt()) {
				age = input.nextInt();
				isNumber = true;
			}
			else {
				System.out.println("Please type a whole number.");
				isNumber = false;
				input.next();
			}
		
		} while (!(isNumber));
		
		
		//Let me save you some time.
		if (age > 20) {
			System.out.println("This person needs to ride the pink roller coaster.");
		}
		else do { 
				System.out.print("How much do you weigh (in pounds):");
				if (input.hasNextInt()) { 
					weight = input.nextInt();
					isNumber = true;
				}
				else {
				  System.out.println("Please type a whole number.");
				  isNumber = false;
				  input.next();
				}
		
		} while (!(isNumber));
		
	
		if (age <= 10) { 
		  if (weight < 80) 
			System.out.println("This person needs to ride the black roller coaster.");
		else if (weight >= 80) 
		  if (weight <=200) 
			System.out.println("This person needs to ride the green roller coaster.");
		else if (weight > 200) 
			System.out.println("This person needs to ride the yellow roller coaster.");
		}
		if (age > 10) {
		  if (age <= 20)
		    if (weight < 80) 
			  System.out.println("This person needs to ride the sliver roller coaster.");
		else if (weight >= 80) 
			   if (weight <=200)  
			  System.out.println("This person needs to ride the red roller coaster.");
		else if (weight > 200) 
			System.out.println("This person needs to ride the purple roller coaster.");
		}
		}
		}


	
		
		
		
			
	


	


