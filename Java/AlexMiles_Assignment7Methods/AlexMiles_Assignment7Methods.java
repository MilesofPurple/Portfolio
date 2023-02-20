import java.util.Scanner;

public class AlexMiles_Assignment7Methods {

public static void main(String[] args)
{
	Scanner input = new Scanner(System.in);
	System.out.println("Would you like to Fib or Fac?");
	String FibFac = input.next();
	CallFibOrFac(FibFac);
	
} //main

public static void CallFibOrFac(String FibFac)
{
int fib = 10;
int fac = 10;
	if (FibFac.equals("Fib"))
		Fibonacci(fib);
	else if (FibFac.equals("Fac"))
		Factorial(fac);
} //CallFibOrFac

public static void Fibonacci(int fib) {
	int swapThen = 1;
	int swapNow = 1;
	int swapAlways = 0;
	if (fib == 0) 
	{
		System.out.print("0");
	}     
	else if (fib == 1) 
	{
		System.out.print("0, 1");
	}         
	else 
	{
		System.out.print("0, 1, ");
	    for (int f = 2; f < fib; ++f) 
	    {
	    swapNow = swapAlways + swapThen;
	    System.out.print(swapNow + ", ");
	    swapAlways = swapThen;
	    swapThen = swapNow;
	    } //for
    } //else
	
} //Fibonacci

public static void Factorial(int fac) {
	int figure = 1;
	if (fac == 0) 
	{
	System.out.print("The fac of " + fac + " is: 0.");
	}
	else for(int f = 1; f <= fac; f++)
	{
	figure = figure * f;
	}
	System.out.print("The Factorial of " + fac + " is: " + figure);
} //Factorial
} //class
