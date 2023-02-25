#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	const int n = 5;
	int i, j, c, sum = 0, a[n];
	int product = 1;
	cout << "\nEnter " << n << " numbers separated by spaces: ";
	for (i = 0; i < n; i++)
	{
		cin >> a[i];
	}//for
	cout << "\nEnter the number you wish to delete: ";
	cin >> j;
	for (i = 0; i < n; i++)
	{
		cout << "\nNew Array Element " << i << ": ";
		if (a[i] != j)
		{
			cout << a[i];
		}
		else cout << "Empty";
	}
	cout << endl;
	system("Pause");
	return 0;
}
