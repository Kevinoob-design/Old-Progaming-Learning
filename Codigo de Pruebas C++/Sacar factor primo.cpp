#include <iostream> //Librera principal
#include <math.h> //Libreria para operaciones Matematicas (sqrt < para Raiz Cuadrada, pow < para elevar)
#include "conio.h"> // Libreria para el "Getch()"
#include <stdlib.h>//Libreria del "System ("Pause")"
#include <string>

using namespace std;

int main(){
	
	cout << "INICIO \n" << endl;
	
	int num, fac = 0, resultado[5], prueba, div = 2;
	int divs[5];
	divs[1] = 0;
	divs[2] = 0;
	divs[3] = 0;
	divs[4] = 0;
	
	cout << "Ingrese el numero "; cin >> num;
	
	if((num != 0) && (num != 1)){
		
		
		resultado[1] = num/div;
		prueba = num%div;
		divs[1] = div;
		
		if(prueba != 0){
			
			do{
				div++;
				resultado[1] = num/div;
				prueba = resultado[1]%div;
				divs[1] = div;
				
			} while(prueba != 0);	
		}
		
		cout << num << "/" << divs[1] << endl;
		div = 2;
		resultado[2] = resultado[1]/div;
		prueba = resultado[1]%div;
		divs[2] = div; 
		
		if(prueba != 0){
			
			do{
				div++;
				resultado[2] = resultado[1]/div;
				prueba = resultado[1]%div;
				divs[2] = div;
				
			} while(prueba != 0);
			
		}
		
		cout << resultado[1] << "/" << divs[2] << endl;
		div = 2;
		resultado[3] = resultado[2]/div;
		prueba = resultado[2]%div;
		divs[3] = div;
		
		if(prueba != 0){
			
			do{
				div++;
				resultado[3] = resultado[2]/div;
				prueba = resultado[2]%div;
				divs[3] = div;
				
				
			} while(prueba != 0);
		}
		
		cout << resultado[2] << "/" << divs[3] << endl;
		div = 2;
		resultado[4] = resultado[3]/div;
		prueba = resultado[3]%div;
		divs[4] = div;
		
		if(prueba != 0){
			
			do{
				div++;
				resultado[4] = resultado[3]/div;
				prueba = resultado[3]%div;
				divs[4] = div;
				
				
			} while(prueba != 0);
		}
		
		cout << resultado[3] << "/" << divs[4] << endl;
		
		cout << "Sus factores primmos son: " << divs[1] <<"*"<< divs[2] <<"*"<< divs[3] <<"*"<< divs[4]<< endl;
	}
	
	cout << "\n";
	cout << "FIN" << endl;
	
	
	system("pause");
	return 0;
}
