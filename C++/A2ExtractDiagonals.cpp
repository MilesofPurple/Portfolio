#include "stdafx.h"
#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	const int rows = 4;
	const int columns = 4;
	int i, j, count = 0, a[rows][columns] = { 10,435,2350,340,2320,20,7247,88,99,5353,30,33,40,41,42,40 };
	int b[columns];
	int sum = rows + columns;
	cout << "Diagonal Array: \n" << a[0][0] << endl;
	for (i = 0; i < rows; i++)
	{
		for (j = 0; j < columns; j++)
		{
			if (i = j)
			{
				b[i] = a[i][j];
				cout << a[i][j] << endl;
			}//if
		}//for
	}//for
	//cout << endl << count << " Zeros detected and removed." << endl;
	system("Pause");
	return 0;
}
