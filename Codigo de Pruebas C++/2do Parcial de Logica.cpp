//Examen 2do parcial Logica de Programacion.
//Prof. Luis Bessewel.
//Estudiante. Hector Morales Veloz 
//Matricula. 2016-1208

/*
1er Programa. Sumar dos numeros cualquiera y con el valor resultante, determinar si es un numero impar
desplegando el mensaje correspondiente, de lo contrario solo desplegar el total.

2do Programa. Digitar un numero cualquiera, evaluar si es menor e igual a 100, de serlo generar la secuencia
de numeros Fibonacci, de dicho numero. Si es mayor que 100, desplegar "No aplica para la generacion de numeros Fibonacci".

3er Programa. Aplicar la forma de evaluar del ITSC para una sola materia, desplegando solo la Nota
y la literal, correspondiente. Evaluar de forma ANIDADA BINARIO ASCENDENTE.

4to Programa. Capturar 4 valores cualquiera y desplazar a su vez la letra y el valor menos capturado.

5to Programa. Capturar 1 valor cualquiera del 1 al 7 y desplegar el dia de la semana en letras. 
Si el valor no cumple desplegar si es primo o no.
*/

#include <iostream>
#include <stdlib.h>
#include <string.h>

using namespace std;

int main(){
	
	int A, B, Suma, num;
	int semana, primo, contador = 0;
	char literal;
	string valor1, valor2, valor3, valor4;
	
	int opcion;
	
	do{
		cout << "Para acceder al primer programa ingrese el numero (1)" << endl;
		cout << "Para acceder al primer programa ingrese el numero (2)" << endl;
		cout << "Para acceder al primer programa ingrese el numero (3)" << endl;
		cout << "Para acceder al primer programa ingrese el numero (4)" << endl;
		cout << "Para acceder al primer programa ingrese el numero (5)" << endl;
		cout << "Para salir del programa ingrese el numero (6)" << endl;
		
		cout << "\nIngrese la opcion deseada: "; cin >> opcion;
		
		switch(opcion){
			
			case 1:
				
				cout << "\nIngrese el valor de la variable (A): "; cin >> A;
				cout << "Ingrese el valor de la variable (B): "; cin >> B;
				
				Suma = A+B;
				
				if(Suma%2 > 0){
					
					cout << "\nEl resultado es " << Suma << " y es un numero inpar" << endl;
				}
				else{
					cout << "\nEl resultado es " << Suma << endl;
				}
				system("pause");
				break;
				
			case 2:
	
				cout << "\nIngrese un numero en un intervalo de de 1 a 100 para generar la secuencia de numeros Fibonacci" << endl;
				
				do{
					cout << "Ingrese el numero: "; cin >> num;
					
					if(num < 0 || num > 100){
						
						cout << "\nEse numero no aplica para la generacion de numeros Fibonacci" << endl;
					}
					
				}while(num < 0 || num > 100);
				
				cout << "\n";
				A = 1;
				B = 0;
				for(int i = 1; i <= num; i++){
					
					A = A+B;
					B = A+B;
					cout << A << endl << B << endl;
					
				}
				system("pause");
				break;
				
			case 3:
				
				cout << "Ingrese la nota de la materia: "; cin >> num;
				
				if((num >= 0) && (num <= 59)){
					
					literal = 'F';	
				}
				else{
					if((num >= 60) && (num <= 69)){
						
						literal = 'D';
					}
					else{
						if((num >= 70) && (num <= 79)){
							
							literal = 'C';
						}
						else{
							if((num >= 80) && (num <= 89)){
								
								literal = 'B';
							}
							else{
								if((num >= 90) && (num <= 100)){
									
									literal = 'A';
								}
							}
						}
					}
				}
				cout << "Su nota es " << num << " y su literal correspondiente es " << literal << endl;
				
				system("pause");
				break;
				
			case 4:
				
				//En este ejercicio perdi completamente el hilo de la logica y no pude terminarlo.
				cout << "\nIngrese 4 valores cualquiera: " << endl; 
				cin >> valor1;
				cin >> valor2;
				cin >> valor3;
				cin >> valor4;
				
				if(valor1 == valor2){
					
					if(valor1 == valor3){
						
						if(valor1 == valor4){
							
							cout << "Todos los valores son iguales, por lo tanto no hay ninguno que haya sido menos ingresado" << endl;
						}
						else{
							cout << "El valor menos ingresado es: " << valor4 << endl;
						}
					}
					else{
						if(valor3 == valor4){
							cout << "2 de los valores tienen un igual ingresado, por lo tanto no hay ninguno que haya sido menos ingresado" << endl;
						}
						else{
							cout << "El " << valor3 <<" y " << valor4 << " fueron los valores menos ingresados" << endl;
						}
					}
				}
				else{
					if(valor1 == valor3){
						
						if(valor1 == valor4){
							cout << "El valor " << valor2 << " es el valor menos ingresado" <<endl;
						}
						else{
							cout << "El " << valor2 << " y " << valor4 << "fueron los valores menos ingresados" << endl;
						}
					}
					else{
						if(valor1 == valor4){
							
							cout << "El " << valor3 << " y " << valor2 << "fueron los valores menos ingresados" << endl;
						}
						else{
							if(valor4 == valor2){
								
								if(valor4 == valor3){
									
									cout << "El valor menos ingresado es " << valor1 << endl;
								}
								else{
									cout << "Los valores menos ingresados son " << valor3 << " y " << valor1 << endl;
								}
							}
							else{
								if(valor2 == valor3){
									cout << "Los valores menos ingresados son " << valor1 << "y " << valor4 << endl;
								}
							}
						}
					}
				}
				
				system("pause");
				break;
				
			case 5:
				cout << "\nIngrese un valor del 1 al 7 para imprimer el dia de la semana correspondiente \nSi el valor no esta en ese parametro se imprimira si el numero ingresado es primo." << endl; 
				cin >> semana;
				
				switch(semana){
					
					case 1:
						cout << "\nEl valor 1 equivale a Domingo" << endl;
						break;
						
					case 2:
						cout << "\nEl valor 2 equivale a Lunes" << endl;
						break;
						
					case 3:
						cout << "\nEl valor 3 equivale a Martes" << endl;
						break;
						
					case 4:
						cout << "\nEl valor 4 equivale a Miercoles" << endl;
						break;
						
					case 5:
						cout << "\nEl valor 5 equivale a Jueves" << endl;
						break;
						
					case 6:
						cout << "\nEl valor 6 equivale a Viernes" << endl;
						break;
						
					case 7:
						cout << "\nEl valor 7 equivale a Sabado" << endl;
						
					default:
						if(semana > 7){
								
							for(int i = 1; i <= semana; i++){
							
								primo = semana;
								primo = semana%i;
								
								if(primo == 0){
										
									contador++;
								}
							}
							
							primo = semana;
							if(contador == 2){
								
								cout << "\n";
								cout << primo << " Es un numero primo" << endl;
								contador = 0;
							}
							else{
								cout << "\n";
								cout << primo << " No es un numero primo" << endl;
								contador = 0;
							}
						}
				}
				
				system("pause");		
				break;
				
			default: cout << "La opcion ingresada no esta dispinible" << endl;
			
		}
		
	system("cls");
	}while(opcion != 6);
	
	
	return 0;
}
