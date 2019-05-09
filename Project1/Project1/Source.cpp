#include <iostream>
#include <string>

using namespace std;

int main() {
	setlocale(LC_ALL, "Rus");
	string name;
	cin >> name;
	cout << "Привет " << name;
	int i;
	for (i = 0; i < 10; i++)
		cout << "Считаю "<< i<< endl;


}