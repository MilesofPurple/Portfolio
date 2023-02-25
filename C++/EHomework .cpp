#include <pch.h>
#include <iostream>
#include <cmath>
using namespace std; //I removed references to any attempt at the bonus.  I think that’s what was confusing.

int main()
{
	double x1 = 7, y1 = 12, x2 = 3, y2 = 9 // setting coordinate values
		double distance;
	distance = sqrt(pow(x2 - x1, 2) + pow(y2 - y1, 2)); //calculates distance for first part of homework
	cout << "The distance between coordinates (" << x1 << ", "
		<< y1 << ") and (" << x2 << ", " << y2 << ") is: " << distance << endl; // answer 1
	cout << "Please input your coordinates, separated by spaces: " << endl;
	cin >> x1 >> y1 >> x2 >> y2;
	distance = sqrt(pow(x2 - x1, 2) + pow(y2 - y1, 2));
	cout << "The distance between (" << x1 << ", " << y1 << ") and ("
		<< x2 << ", " << y2 << ") is: " << distance << endl; // answer 2
	x1 = 7, y1 = 12, x2 = 3, y2 = 9;
	system("pause");
	return 0;
}