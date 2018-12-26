#include <iostream>

using std::cout;
using std::endl;
using std::cin;

int main() {
	//int zahl1_zum_multiplizieren;
	//int zahl2_zum_multiplizieren;
	//int ergebnis_multiplikation;

	//// INPUT VOM USER
	//cout << "Gebe Zahl1 ein!" << endl;
	//cin >> zahl1_zum_multiplizieren;
	//cout << "Gebe Zahl2 ein!" << endl;
	//cin >> zahl2_zum_multiplizieren;

	//// Mult *, Add +, SUbtr -, Div /
	//ergebnis_multiplikation = zahl1_zum_multiplizieren * zahl2_zum_multiplizieren;

	//cout << "Ergebnis: " << ergebnis_multiplikation << endl;

	//float

	float komma_zahl;
	double komma_zahl2;

	komma_zahl = 0.1f;
	komma_zahl2 = 0.2;

	cout << "Komma1: " << komma_zahl << endl;
	cout << "Komma2: " << komma_zahl2 << endl;

	//char

	char buchstabe1;
	buchstabe1 = 'a';

	cout << "Buchstabe1: " << buchstabe1 << endl;

	//bool

	bool aussage1 = true;
	bool aussage2 = false;

	cout << "Aus1: " << aussage1 << endl;
	cout << "Aus2: " << aussage2 << endl;

	cin.get();
	getchar();
	return 0;
}