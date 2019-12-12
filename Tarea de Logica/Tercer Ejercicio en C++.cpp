//Realizar un programa que dado 8 valores capturados determine la variable que tenga el numero menor, evaluando con If anidados compuestos.

#include <iostream>
#include <conio.h>

using namespace std;

int valor1, valor2, valor3, valor4, valor5, valor6, valor7, valor8;

int main(){
	
	cout << "Ingrese 8 valores numericos" << endl;
	cin >> valor1 >> valor2 >> valor3 >> valor4 >> valor5 >> valor6 >> valor7 >> valor8;
	
	if((valor1 < valor2) and (valor1 < valor3) and (valor1 < valor4) and (valor1 < valor5) and (valor1 < valor6) and (valor1 < valor7) and (valor1 < valor8)){
		
		cout << "La variable que contiene el numero menor es: valor1 " << endl;
	}
	else{
		
		if((valor2 < valor1) and (valor2 < valor3) and (valor2 < valor4) and (valor2 < valor5) and (valor2 < valor6) and (valor2 < valor7) and (valor2 < valor8)){
			
			cout << "La variable que contiene el numero menor es: valor2 " << endl;
		}
		else{
			
			if((valor3 < valor1) and (valor3 < valor2) and (valor3 < valor4) and (valor3 < valor5) and (valor3 < valor6) and (valor3 < valor7) and (valor3 < valor8)){
				
				cout << "La variable que contiene el numero menor es: valor3 " << endl;
			}
			else{
				
				if((valor4 < valor1) and (valor4 < valor2) and (valor4 < valor3) and (valor4 < valor5) and (valor4 < valor6) and (valor4 < valor7) and (valor4 < valor8)){
					
					cout << "La variable que contiene el numero menor es: valor4 " << endl;
				}
				else{
					
					if((valor5 < valor1) and (valor5 < valor2) and (valor5 < valor3) and (valor5 < valor4) and (valor5 < valor6) and (valor1 < valor7) and (valor1 < valor8)){
						
						cout << "La variable que contiene el numero menor es: valor5 " << endl;
					}
					else{
						
						if((valor6 < valor1) and (valor6 < valor2) and (valor6 < valor3) and (valor6 < valor4) and (valor6 < valor5) and (valor6 < valor7) and (valor6 < valor8)){
							
							cout << "La variable que contiene el numero menor es: valor6 " << endl;
						}
						else{
							
							if((valor7 < valor1) and (valor7 < valor2) and (valor7 < valor3) and (valor7 < valor4) and (valor7 < valor5) and (valor7 < valor6) and (valor7 < valor8)){
								
								cout << "La variable que contiene el numero menor es: valor7 " << endl;
							}
							else{
								
								if((valor8 < valor1) and (valor8 < valor2) and (valor8 < valor3) and (valor8 < valor4) and (valor8 < valor5) and (valor8 < valor6) and (valor8 < valor7)){
									
									cout << "La variable que contiene el numero menor es: valor8 " << endl;
								}
							}
						}
					}
				}
			}
		}
	}
	
	
	getch();
	return 0;
}
