import java.util.Scanner;

public class Assignment5Strings {
	
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		Scanner input = new Scanner(System.in);
		
		//Alex Miles, 3/15/18, 05 String Builder Class assignment
		
		//gathering string input
		System.out.print("Please input 3 capitalized city names separated by spaces in one line and press Enter.");	
		String s1 = input.next();
		String s2 = input.next();
		String s3 = input.next();
		
		//alphabetical assignment
		String city;
		if ((s2.compareTo(s1) < 0) && (s2.compareTo(s3) < 0)) {
			city = s1;
			s1 = s2;
			s2 = city;
		}
		else if ((s3.compareTo(s1) < 0) && (s3.compareTo(s2) < 0)) {
			city = s1;
			s1 = s3;
			s3 = city;
		}
		if (s3.compareTo(s2) < 0) {
			city = s2;
			s2 = s3;
			s3 = city;
		}
		
		//Print cities in alphabetical order
		System.out.println (s1 + "\n" + s2 + "\n" + s3);
	
		}

}
