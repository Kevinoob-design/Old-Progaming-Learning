//un programa que determine que tipo de triangulo es segun tres valores introducidos por el teclado equivalente a sus lados.

#include <iostream>
#include <stdlib.h>

using namespace std;

int a, b, c;

int main(){
	
	cout << "Introduzca los valores del tipo de triangulo deseado\n" << endl;
	cin >> a >> b >> c;
	
	if(((a == b) and (a == c)) and ((b == a) and (b == c)) and (c == a) and (c == b)){
		
		cout << "Introdujo un triangulo equilatero" << endl;
	}
	else{
		if(((a == c) and (a != b) and ((b != a) and (b != c)) and ((c == a) and (c != b))) 
		or 
		((a != c) and (a == b) and ((b == a) and (b != c)) and ((c != a) and (c != b))) 
		or 
		((a != c) and (a != b) and ((b != a) and (b == c)) and ((c != a) and (c == b)))){
			
			cout << "Introdujo un triangulo isosceles" << endl;
		}
		else{
			
			if(((a != b) and (a != c)) and ((b != a) and (b != c)) and ((c != a) and (c != b))){
				
				cout << "Introdujo un triangulo escaleno" << endl;
			}
		}
	}
	
	
	
	system("pause");
	return 0;
}
