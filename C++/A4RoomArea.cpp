#include "stdafx.h"
#include <iostream>
#include <iomanip>
using namespace std;

class RoomType
{
private:
	double width; //Added by Alex Miles on 12/1/18
	double length; //Declare length as a double variable double width; //Declare width as a double variable 
public:
	RoomType(double = 0.0, double = 0.0); //The constructor's declaration void showRoomValues();
	void setNewRoomValues(double, double);
	double calculateRoomArea();
	void showRoomValues();
};
//Class implementation section
RoomType::RoomType(double l, double w) //This is a constructor 
{
	length = l;
	width = w;
}//RoomType

void RoomType::showRoomValues() //Accessor 
{
	cout << " Length = " << length
		<< "\n width = " << width << endl;
}//Accessor

void RoomType::setNewRoomValues(double l, double w) //Mutator 
{
	length = l;
	width = w;
}//mutator
double RoomType::calculateRoomArea() //Performs the area calculation 
{
	return (length * width);
}//area calculation
int main() {
	//Declares variable of type of RoomType with length x width dimensions 
	RoomType Hall(12.40, 3.5);
	RoomType Kitchen(14, 14);
	RoomType LivingRoom(12.4, 20);
	RoomType DiningRoom(10.6, 8.0); //Modified from 14, 10.5 by Alex Miles on 12/1/18
	RoomType BathRoom(10.2, 10.5); //Room added by Alex Miles on 12/1/18
	double sum = 0; //Sum double variable to stores the area of each room after calculation 
	cout << "---------Hall----------------\n";
	cout << "The area of the hall is: " << Hall.calculateRoomArea(); cout << endl;
	sum = sum + Hall.calculateRoomArea(); //Adds hall area into sum 
	cout << "\n---------Kitchen-------------\n";
	cout << "The area of the kitchen is: " << Kitchen.calculateRoomArea(); cout << endl;
	sum = sum + Kitchen.calculateRoomArea(); //Adds kitchen area into sum 
	cout << "\n---------Living Room---------\n";
	cout << "The area of the living room is: " << LivingRoom.calculateRoomArea(); cout << endl;
	sum = sum + LivingRoom.calculateRoomArea(); //Adds living room area into sum 
	cout << "\n---------Dining Room---------\n";
	cout << "The area of the dining room is: " << DiningRoom.calculateRoomArea(); cout << endl;
	sum = sum + DiningRoom.calculateRoomArea(); //Adds dining room area into sum 
	cout << "\n---------Bath Room---------\n";
	cout << "The area of the bath room is: " << BathRoom.calculateRoomArea(); cout << endl;
	sum = sum + BathRoom.calculateRoomArea(); //Adds bath room area into sum 
	cout << "\n---------All 5 Rooms---------\n"; //AM 5 rooms now!
	cout << "The total area of all 5 rooms combined is: "
		<< sum; //Outputs value of each room's area that has been stored into sum 
	cout << endl << endl;
	system("pause");
	return 0;
}
