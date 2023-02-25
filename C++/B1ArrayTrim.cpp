#include "amhw61.h"
#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	int i, l, n = 5, j, a[5];
	cout << "\nEnter " << n << " numbers separated by spaces: ";
	for (i = 0; i < n; i++)
	{
		cin >> a[i];
	}//for
	for (j = 0; j < n; j++)
	{
		for (i = j + 1; i < n;)
		{
			if (a[i] == a[j])
			{
				for (l = i; l < n - 1; l++)
					a[j] = a[j + 1];
				n--;
			}//if ai == aj
			else i++;
		}//i for

	}//j for
	cout << "\nThe updated array is: ";
	for (j = 0; j < n; j++)
		cout << a[j] << " ";
	system("Pause");
	return 0;
}
