#include <iostream>
#include <stdlib.h>

using namespace std;

int main(){


int num, par, ipar, x, i = 0;

		cout << "ingrese un numero cualquiera "; cin >> num;
		
		do {
		
			i++;
			x = i % 2;
			if (x == 0) {

				par = i;
				cout << "este numero si es par: " << par << endl;
			}

			if (x != 0) {

				ipar = i;
				cout << "este numero no es par: " << ipar << endl;
			}
		}while(i != num);
		
		system("pause");
		return 0;
	}
		
