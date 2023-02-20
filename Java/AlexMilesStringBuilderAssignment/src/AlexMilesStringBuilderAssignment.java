
public class AlexMilesStringBuilderAssignment {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		//Alex Miles, 3/15/18, 06 String Builder Class assignment
		
		//inserting string
		String tcc = ("It was the best of times, "
				+ "it was the worst of times, "
				+ "it was the age of wisdom, "
				+ "it was the age of foolishness, "
				+ "it was the epoch of belief, "
				+ "it was the epoch of incredulity, "
				+ "it was the season of Light, "
				+ "it was the season of Darkness, "
				+ "it was the spring of hope, "
				+ "it was the winter of despair, "
				+ "we had everything before us, "
				+ "we had nothing before us, "
				+ "we were all going direct to Heaven, "
				+ "we were all going direct the other way-- in short, "
				+ "the period was so far like the present period, "
				+ "that some of its noisiest authorities insisted on its being received, "
				+ "for good or for evil, "
				+ "in the superlative degree of comparison only.");
		
		//not going to do if else
		String colon = ":";
		String name = "Alex";
		
		//replacing "It" with name
		String tcc1 = tcc.replaceAll("It", name);
		
		//replacing "it" with name
		String tcc2 = tcc1.replaceAll("it", name);
		
		//replacing commas with colons
		String tccfinal = tcc2.replaceAll(",", colon);
		System.out.println(tccfinal);
	}

}
