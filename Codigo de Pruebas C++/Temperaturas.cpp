#include <iostream> //Librera principal
#include <math.h> //Libreria para operaciones Matematicas (sqrt < para Raiz Cuadrada, pow < para elevar)
#include "conio.h"> // Libreria para el "Getch()"
#include <stdlib.h>//Libreria del "System ("Pause")"

using namespace std;

int main(){
	
	cout << "INICIO \n" << endl;
	
	int baja, alta, media;
	int temperatura;
	int hora = 0;
	int suma;
	
	int temperaturas[6];
	
	
	cout << "El programa leera 6 temperaturas en las proximas 24 horas \n" << endl;
	
	for (int dia=0; dia<24;){
		
		cout << "Ingrese la temperatura de las " << hora << "hrs hasta las " << hora+4 << "hrs: "; cin >> temperatura;
		hora = hora+4;
		dia +=4;
		
		cout << "\nEn el transcurso de " << dia << "rs, la temperatura a sido de: " << temperatura << "\n" << endl;
	
		
		if (hora == 4){
			temperaturas[1] = temperatura;
		}

		
		if (hora == 8){
			temperaturas[2] = temperatura;
		}

		
		if (hora == 12){
			temperaturas[3] = temperatura;
		}

		
		if (hora == 16){
			temperaturas[4] = temperatura;
		}

		if (hora == 20){
			temperaturas[5] = temperatura;
		}
		
		if (hora == 24){
			temperaturas[6] = temperatura;
		}
	}
	
	suma = temperaturas[1]+temperaturas[2]+temperaturas[3]+temperaturas[4]+temperaturas[5]+temperaturas[6];
	
	baja = temperaturas[1];
	media = suma/6;
	alta = temperaturas[6];
	
	cout << "la temperatura mas baja fue de: " << baja << endl;
	cout << "La temperatura media fue de: " << media << endl;
	cout << "La temperatura mas alta fue de: " << alta << endl;
	
	cout << "\n";
	cout << "FIN" << endl;
	
	
	system("pause");
	return 0;
}
