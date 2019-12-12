#include <windows.h>
#include <stdlib.h>
#include <iostream>
#include <conio.h>
#include <string.h>

using namespace std;

char literal[] = { 'F', 'D', 'C', 'B', 'A' };
double nota[7], notas[7], indice[2];
int credito[] = {0, 0, 0, 0, 0, 0, 0, 0};
int totalc, totaln, total[7];
int materias;
int salida;
bool salir = true;
char comprobante;

int main() {


	cout << "ESTA ES UNA CALCULADORA DE INDICE DEL ITSC" << endl;
	cout << "CREADA POR HECTOR J. MORALES VELOZ" << endl;
	cout << "FECHA: 6/3/2017 " << endl;
	cout << "\n" << endl;

	system("pause");

	HANDLE Aster;
	Aster = GetStdHandle(STD_OUTPUT_HANDLE);

	COORD Posi;
	COORD Posi2;
	COORD Posi3;
	COORD Posi4;

	COORD Esq1;
	COORD Esq2;
	COORD Esq3;
	COORD Esq4;

	COORD End;
	End.X = 3;
	End.Y = 28;

	COORD IndiE, IndiI;
	IndiE.X = 87;
	IndiE.Y = 2;

	do {
		COORD Error;
		Error.X = 88;
		Error.Y = 3;

		COORD Ini;
		Ini.X = 3;
		Ini.Y = 2;
		int Y = 0;
		int Y2 = 2;

		IndiI.X = 2;
		IndiI.Y = 1;

		COORD Head;
		Head.X = 3;
		Head.Y = 3;

		system("cls");

		SetConsoleCursorPosition(Aster, IndiI);
		cout << "\t\t\t\t\t\t CALCULADORA DE INDICE" << endl;

		SetConsoleCursorPosition(Aster, IndiE);
		cout << "INDICADOR DE ERRORES" << endl;

		Error.X = 81;
		Error.Y = Error.Y + 1;
		SetConsoleCursorPosition(Aster, Error);
		cout << "-Ingresar un caracter";
		Error.X = 81;
		Error.Y = Error.Y + 1;
		SetConsoleCursorPosition(Aster, Error);
		cout << " hara fallar el programa";

		for (int I = 2; I <= 117; I++) {

			Posi.X = I;
			Posi.Y = 0;

			Posi2.X = 1;
			Posi2.Y = 1;

			Posi3.X = 118;
			Posi3.Y = 1;

			Posi4.Y = 29;
			Posi4.X = I;

			if (I <= 29) {

				Y = Y + 1;
				Posi2.Y = Y;
				Posi3.Y = Y;
			}

			Esq1.X = 1;
			Esq1.Y = 0;

			SetConsoleCursorPosition(Aster, Esq1);
			cout << char(218);

			Esq2.X = 118;
			Esq2.Y = 0;

			SetConsoleCursorPosition(Aster, Esq2);
			cout << char(191);

			Esq4.X = 1;
			Esq4.Y = 29;

			SetConsoleCursorPosition(Aster, Esq4);
			cout << char(192);

			Esq3.X = 118;
			Esq3.Y = 29;

			SetConsoleCursorPosition(Aster, Esq3);
			cout << char(217);

			SetConsoleCursorPosition(Aster, Posi);
			cout << char(196);

			SetConsoleCursorPosition(Aster, Posi2);
			cout << char(179);

			SetConsoleCursorPosition(Aster, Posi3);
			cout << char(179);

			SetConsoleCursorPosition(Aster, Posi4);
			cout << char(196);
		}

		for (int I = 114; I >= 81; I--) {

			Posi.X = I;
			Posi.Y = 1;

			Posi2.X = 80;
			Posi2.Y = 2;

			Posi3.X = 115;
			Posi3.Y = 2;

			Posi4.Y = 18;
			Posi4.X = I;

			if (I >= 100) {

				Y2 = Y2 + 1;
				Posi2.Y = Y2;
				Posi3.Y = Y2;
			}

			Esq1.X = 80;
			Esq1.Y = 1;

			SetConsoleCursorPosition(Aster, Esq1);
			cout << char(218);

			Esq2.X = 115;
			Esq2.Y = 1;

			SetConsoleCursorPosition(Aster, Esq2);
			cout << char(191);

			Esq4.X = 80;
			Esq4.Y = 18;

			SetConsoleCursorPosition(Aster, Esq4);
			cout << char(192);

			Esq3.X = 115;
			Esq3.Y = 18;

			SetConsoleCursorPosition(Aster, Esq3);
			cout << char(217);

			SetConsoleCursorPosition(Aster, Posi);
			cout << char(196);

			SetConsoleCursorPosition(Aster, Posi2);
			cout << char(179);

			SetConsoleCursorPosition(Aster, Posi3);
			cout << char(179);

			SetConsoleCursorPosition(Aster, Posi4);
			cout << char(196);

		}

		Ini.Y = Ini.Y + 1;
		SetConsoleCursorPosition(Aster, Ini);
		cout << "-Si desea salir ingrese (0)" << endl;

		do {
			
			Ini.Y = 4;
			SetConsoleCursorPosition(Aster, Ini);
			cout << "Ingrese la cantidad de materias que tomo: "; cin >> materias;
			
			if (Ini.Y > 25) {

				for (int Er = 4; Er <= 26; Er++) {

					Ini.Y = Er;
					SetConsoleCursorPosition(Aster, Ini);
					cout << "                                            ";
				}

				Ini.Y = 3;

			}

			if (materias > 7) {

				Ini.X = 45;
				SetConsoleCursorPosition(Aster, Ini);
				cout << "          ";
				Ini.X = 3;

				Error.X = 81;
				Error.Y = Error.Y + 1;
				SetConsoleCursorPosition(Aster, Error);
				cout << "-El limite de materias es 7" << endl;

				if (Error.Y > 15) {

					for (int E = 6; E <= 16; E++) {

						Error.Y = E;
						SetConsoleCursorPosition(Aster, Error);
						cout << "                             ";
					}

					Error.Y = 5;
				}
			}
			if (materias < 0) {

				Ini.X = 45;
				SetConsoleCursorPosition(Aster, Ini);
				cout << "                    ";
				Ini.X = 3;

				Error.X = 81;
				Error.Y = Error.Y + 1;
				SetConsoleCursorPosition(Aster, Error);
				cout << "-No puede ingresar un numero";
				Error.X = 81;
				Error.Y = Error.Y + 1;
				SetConsoleCursorPosition(Aster, Error);
				cout << " negativo de materias";

				if (Error.Y > 15) {

					for (int E = 6; E <= 17; E++) {

						Error.Y = E;
						SetConsoleCursorPosition(Aster, Error);
						cout << "                             ";
					}

					Error.Y = 5;
				}
			}
			if((materias >= '!' && materias <= '/') || (materias >= ':' && materias <= '~')){
				
				Ini.X = 45;
				SetConsoleCursorPosition(Aster, Ini);
				cout << "          ";
				Ini.X = 3;

				Error.X = 81;
				Error.Y = Error.Y + 1;
				SetConsoleCursorPosition(Aster, Error);
				cout << "No puede ingresar caracteres " << endl;
				 materias = 8;
				 
			}
			

		} while ((materias > 7) || (materias < 0));

		if (materias == 0) {

			salir = false;
		}

		if ((materias > 0) && (materias < 8)) {

			SetConsoleCursorPosition(Aster, Head);
			cout << "-Ya no podra salir del programa introduciendo (0) hasta terminarlo";

			Ini.Y = Ini.Y + 1;
			SetConsoleCursorPosition(Aster, Ini);
			cout << "\n";

			Ini.Y = 6;

			for (int i = 0; i <= materias; i++) {

				do {
					SetConsoleCursorPosition(Aster, Ini);
					cout << "Ingrese la nota de la materia " << i << ": "; cin >> nota[i];
					notas[i] = nota[i];

					if (Ini.Y > 25) {

						for (int Er = 4; Er <= 26; Er++) {

							Ini.Y = Er;
							SetConsoleCursorPosition(Aster, Ini);
							cout << "                                            ";
						}

						Ini.Y = 3;
					}

					if ((nota[i] < 0) || (nota[i] > 100)) {

						Ini.X = 36;
						SetConsoleCursorPosition(Aster, Ini);
						cout << "          ";
						Ini.X = 3;

						Error.X = 81;
						Error.Y = Error.Y + 1;
						SetConsoleCursorPosition(Aster, Error);
						cout << "-Debe ingresar una nota";
						Error.X = 81;
						Error.Y = Error.Y + 1;
						SetConsoleCursorPosition(Aster, Error);
						cout << " en un intervalo de 0 a 100";

						if (Error.Y > 15) {

							for (int E = 6; E <= 17; E++) {

								Error.Y = E;
								SetConsoleCursorPosition(Aster, Error);
								cout << "                             ";
							}

							Error.Y = 5;
						}
					}

				} while ((nota[i] < 0) || (nota[i] > 100));

				Ini.Y += 1;

				do {
					SetConsoleCursorPosition(Aster, Ini);
					cout << "Ingrese los creditos de la materia " << i << ": "; cin >> credito[i];

					if (Ini.Y > 25) {

						for (int Er = 4; Er <= 26; Er++) {

							Ini.Y = Er;
							SetConsoleCursorPosition(Aster, Ini);
							cout << "                                            ";
						}

						Ini.Y = 3;
					}

					if ((credito[i] < 1) || credito[i] > 4) {

						Ini.X = 39;
						SetConsoleCursorPosition(Aster, Ini);
						cout << "          ";
						Ini.X = 3;

						Error.X = 81;
						Error.Y = Error.Y + 1;
						SetConsoleCursorPosition(Aster, Error);
						cout << "-Debe ingresar los creditos";
						Error.X = 81;
						Error.Y = Error.Y + 1;
						SetConsoleCursorPosition(Aster, Error);
						cout << " en un intervalo de 1 a 4";

						if (Error.Y > 15) {

							for (int E = 6; E <= 17; E++) {

								Error.Y = E;
								SetConsoleCursorPosition(Aster, Error);
								cout << "                             ";
							}

							Error.Y = 5;
						}
					}

				} while ((credito[i] < 1) || (credito[i] > 4));

				total[i] = credito[i] * nota[i];

				Ini.Y = Ini.Y + 1;
				SetConsoleCursorPosition(Aster, Ini);
				cout << "\n";
			}

			totaln = total[1] + total[2] + total[3] + total[4] + total[5] + total[6] + total[7];
			totalc = credito[1] + credito[2] + credito[3] + credito[4] + credito[5] + credito[6] + credito[7];

			indice[1] = totaln / totalc;
			indice[2] = indice[1] * 4 / 100;

			Ini.Y = Ini.Y + 1;
			SetConsoleCursorPosition(Aster, Ini);
			cout << "\n";

			Ini.Y = Ini.Y + 1;
			SetConsoleCursorPosition(Aster, Ini);
			cout << "Su indice academico es: " << indice[2];
			Ini.Y = Ini.Y + 1;
			SetConsoleCursorPosition(Aster, Ini);
			cout << "\n";

			COORD Lit;
			Lit.X = 95;
			Lit.Y = 19;

			

			for (int i = 1; i <= materias; i++) {


				if (nota[i] <= 59) {

					SetConsoleCursorPosition(Aster, Lit);
					cout << "Usted obtuvo " << literal[0];

				}
				else {
					if (nota[i] <= 69) {

						SetConsoleCursorPosition(Aster, Lit);
						cout << "Usted obtuvo " << literal[1];

					}
					else {
						if (nota[i] <= 79) {

							SetConsoleCursorPosition(Aster, Lit);
							cout << "Usted obtuvo " << literal[2];
						}
						else {
							if (nota[i] <= 89) {

								SetConsoleCursorPosition(Aster, Lit);
								cout << "Usted obtuvo " << literal[3];
							}
							else {
								if ((nota[i] <= 100) && (nota[i] >= 90)) {

									SetConsoleCursorPosition(Aster, Lit);
									cout << "Usted obtuvo " << literal[4];
								}
							}
						}
					}
				}

				Lit.Y = Lit.Y + 1;
			}

			do {
				SetConsoleCursorPosition(Aster, End);
				cout << "Si desea salir del programa ingrese (0), si desea calcular otro indice ingrese (1): "; cin >> salida;

				if ((salida != 1) && (salida != 0)) {

					Error.X = 81;
					Error.Y = Error.Y + 1;
					SetConsoleCursorPosition(Aster, Error);
					cout << "Debe ingresar (0) o (1): ";

					End.X = 80;
					SetConsoleCursorPosition(Aster, End);
					cout << "                            ";

					End.X = 3;

					if (Error.Y > 15) {

						for (int E = 6; E <= 16; E++) {

							Error.Y = E;
							SetConsoleCursorPosition(Aster, Error);
							cout << "                             ";
						}

						Error.Y = 5;
					}
				}

			} while (salida != 1 && salida != 0);

			if (salida == 1) {

				salir = true;
			}
			if (salida == 0) {

				salir = false;
			}

		}
	} while (salir != false);

	return 0;
}


