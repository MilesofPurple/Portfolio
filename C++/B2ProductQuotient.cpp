#include "ProductQuotient"
#include <iostream>
#include <iomanip>
using namespace std;


int main()
{
	int n;
	int count, o;
	for (count = 0; count < 3; count++)
	{
		cout << "Please enter a number: ";
		cin >> n;
		cout << "\nWould you like to divide (1) or multiply? (2): ";
		cin >> o;
		if (o == 1)
		{
			cout << "\nYou chose divide!  " << n << " divided by 8 equals: " << (n * .125) << endl;
		}//if o = 1
		else if (o == 2)
		{
			cout << "\nYou chose multiply! " << n << " multiplied by 4 equals: " << (n + n + n + n) << endl;
		}
		else cout << "\nSorry, I couldn't understand your selection.";
		cout << endl;
	}//for
	system("Pause");
	return 0;
}
