#include "stdafx.h"
#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	const int n = 3;
	int i;
	double sum = 0, a[n];
	cout << "Please enter " << n << " numbers, separated by spaces, to build the array: ";
	for (i = 0; i < n; i++)
	{
		cin >> a[i];
	}//for
	for (i = 0; i < n; i++)
	{
		sum = sum + *(a + i);
	}
	cout << "\nThe sum of the array is: " << sum << endl;
	system("Pause");
	return 0;
}
