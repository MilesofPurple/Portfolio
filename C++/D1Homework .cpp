#include "AMHW4.h"
#include <iostream>
#include <iomanip>
using namespace std;


int main()
{
	double input;
	double sum = 0;
	double experiment;
	double maxexp = 4;
	double maxdata = 6;
	double data = 6;
	cout << "\nDefault is " << maxdata << " maximum data samples across " << maxexp << " experiments." << endl;
	for (experiment = 1; experiment <= maxexp; experiment++) { //code by Alex Miles
		cout << "\nPlease input " << maxdata << " data samples for experiment " << experiment << endl;
		for (data = 1; data <= maxdata; data++) {
			cout << "Enter data sample " << data << " and press enter. ";
			cin >> input;
			sum = (input + sum);
		}// end of data loop
		cout << "\nThe average of experiment " << experiment << " is: " << (sum / maxdata);
	}// end of experiment loop
	cout << "\nEnd of experiments." << endl << "Goodbye!";
	system("Pause");
	return 0;
}
