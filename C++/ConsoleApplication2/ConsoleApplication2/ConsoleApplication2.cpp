

#include <pch.h>
#include <iostream>
#include <cmath>
using namespace std;

int main()
{
	double x1 = 7, y1 = 12, x2 = 3, y2 = 9, x3 = 8, y3;
	double distance;
	double bonusy;
	y3 = sqrt(pow(x2 - x1, 2) + pow(y2 - y1, 2) - pow(x3 - x1, 2)); 
	distance = sqrt(pow(x2 - x1, 2) + pow(y2 - y1, 2));				
	cout << "The distance between coordinates (" << x1 << ", "
		<< y1 << ") and (" << x2 << ", " << y2 << ") is: "
		<< distance << endl;
	cout << "Please input your coordinates, separated by spaces: " << endl;
	cin >> x1 >> y1 >> x2 >> y2;
	distance = sqrt(pow(x2 - x1, 2) + pow(y2 - y1, 2));
	cout << "The distance between (" << x1 << ", " << y1 << ") and ("
		<< x2 << ", " << y2 << ") is: " << distance << endl;
	x1 = 7, y1 = 12, x2 = 3, y2 = 9; // resetting coordinates
	bonusy = sqrt(pow(x3 - x2, 2) + pow(y3 - y2, 2));
	cout << "Bonus point attempt: " << distance << " and "
	<< bonusy << "!" << endl;
	system("pause");
	return 0;
}