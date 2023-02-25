#include "stdafx.h"
#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	const int rows = 3;
	const int columns = 3;
	int i, j, count = 0, a[rows][columns] = { 4,2,5,0,9,8,0,7,0 };
	int sum = rows + columns;
	//cout << "Please enter " << sum << " numbers, separated by spaces, to build the array: ";
	for (i = 0; i < rows; i++)
		for (j = 0; j < columns; j++)
		{
			if (a[i][j] != 0)
			{
				cout << a[i][j] << " ";
			}
			else count++;
		}//for
	cout << endl << count << " Zeros detected." << endl;
	system("Pause");
	return 0;
}
