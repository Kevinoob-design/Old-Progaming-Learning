#include <iostream> //Librera principal
#include <math.h> //Libreria para operaciones Matematicas (sqrt < para Raiz Cuadrada, pow < para elevar)
#include "conio.h"> // Libreria para el "Getch()"
#include <stdlib.h>//Libreria del "System ("Pause")"
#include <string>
#include <time.h>

using namespace std;

int main(){
	
	cout << "INICIO \n" << endl;
	
	int num, dato, contador = 0;
	
	srand(time(NULL));
	dato = 1+rand()% (100);
	
	cout << "Digite un numero "; cin >> num;
	
	do{
		if(num>dato){
			
			cout << "\nDigite un numero menor "; cin >> num;
		}
		if(num<dato){
			
			cout << "\nDigite un numero mayor "; cin >> num;
		}
		
		contador++;
		
		
	} while (num != dato);
	
	cout << "\nLo lograste en " << contador << " intentos" << endl;
	
	cout << "\n";
	cout << "FIN" << endl;
	
	
	system("pause");
	return 0;
}
