#include "AMHW51.h"
#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	const int n = 11;
	int i, j, a[n], b[n];
	j = n - 1;
	cout << "\nEnter " << n << " numbers separated by spaces: ";
	for (i - 0; i < n; i++)
	{
		cin >> a[i];
		b[j] = a[i];
		j = j - 1;
	}//for
	for (i = 0; i < n; i++)
		cout << "\n Original Array Element " << i << "     Reversed Array Element " << i;
	cout << endl;
	system("Pause");
	return 0;
}
