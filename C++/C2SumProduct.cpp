#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	const int n = 20;
	int i, sum = 0, a[n];
	int product = 1;
	cout << "\nEnter " << n << " numbers separated by spaces: ";
	for (i = 0; i < n; i++)
	{
		cin >> a[i];
		sum = (sum + a[i]);
		product = (product * a[i]);
	}//for
	for (i = 0; i < n; i++)
		cout << "\n Original Array Element " << i << ": " << a[i];
	cout << "\nSum of the array is: " << sum << "\nProduct of the array is: " << product << endl;
	system("Pause");
	return 0;
}
