package alexmiles_chapter9_objectsandclasses;

public class Rectangle {

	public static void main(String[] args) {
		
		Rectangle rectangle1 = new Rectangle(4, 40);
		System.out.println("Rectangle 1 Stats: "
				+ "Width: " + rectangle1.rwidth
				+ " inches. Height: " + rectangle1.rheight
				+ " inches. Area: " + rectangle1.getArea()
				+ " inches. Perimeter: " + rectangle1.getPerimeter()
				+ " inches. Diagonal: " + rectangle1.getDiagonal()
				+ " inches.");
		
		Rectangle rectangle2 = new Rectangle(3.5, 35.9);
		System.out.println("Rectangle 2 Stats: "
				+ "Width: " + rectangle2.rwidth
				+ " inches. Height: " + rectangle2.rheight
				+ " inches. Area: " + rectangle2.getArea()
				+ " inches. Perimeter: " + rectangle2.getPerimeter()
				+ " inches. Diagonal: " + rectangle2.getDiagonal()
				+ " inches.");
	
    }//main
  	
	double rwidth;
	double rheight;
	
	Rectangle() {
		rwidth = 1;
		rheight = 1;
    }//default rectangle
	
	Rectangle(double newRwidth, double newRheight) {
		rwidth = newRwidth;
		rheight = newRheight;
	}//new rectangle
	
	double getArea() {
		return rwidth * rheight;
	}//getArea
	
	double getPerimeter() {
		return (rwidth + rheight) * 2;
	}//getPerimeter
	
	double getDiagonal() {
		return Math.sqrt((rwidth) * (rwidth) + (rheight * rheight));
	}//getDiagonal
	
	void setSize(double newRwidth, double newRheight) {
		rwidth = newRwidth;
		rheight = newRheight;
	}//setSize
	
}//class
