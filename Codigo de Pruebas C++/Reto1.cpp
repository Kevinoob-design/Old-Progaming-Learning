#include <iostream>
#include <stdlib.h>

using namespace std;

int main(){
	
	int a, b, c, x = 0;
	
	cout << "Ingrese el valor de las 3 variables A, B y C" << endl;
	cout << "Valor de A: "; cin >> a; cout << " Valor de B: "; cin >> b; cout << " Valor de C: "; cin >> c;
	
	x = a;
	a = b;
	b = c;
	c = x;
	
	cout << "El nuevo valor de A es: " << b << " El nuevo valor de B es: " << c << " Y el nuevo valor de C es: " << a << endl;
	
	
	
	system("pause");
	return 0;
}
