#include<iostream>
#include<cmath>
using namespace std;

int main() {
	float a, b, bono, c, deuda, final, hr_extra, isr, sobra[] = {0,0,0,0,0}, sueldo;
	cout << "Algoritmo para calcular descuentos" << endl;
	cout << "" << endl;
	cout << "" << endl;
	cout << "INTRODUZCA SU SUELDO" << endl;
	cin >> sueldo;
	cout << "INTRODUZCA HORAS EXTRAS" << endl;
	cin >> hr_extra;
	cout << "INTRODUZCA BONIFICACION" << endl;
	cin >> bono;
	cout << "INTRODUZCA DEUDA A PAGAR" << endl;
	cin >> deuda;
	
	a = (sueldo*3.04)/100;
	b = (sueldo*2.87)/100;
	c = a+b+deuda;
	
	sobra[0] = sueldo-c;
	sobra[1] = sobra[0]*12;
	if (sobra[1]>416220.00) {
		sobra[2] = sobra[1]-416220.00;
		sobra[3] = (sobra[2]*15)/100;
		isr = sobra[3]/12;
	}
	if (sobra[1]>624329.01) {
		sobra[2] = sobra[1]-624329.01;
		sobra[3] = (sobra[2]*20)/100;
		sobra[4] = sobra[3]+29994;
		isr = sobra[4]/12;
	}
	if (sobra[1]>867123.01) {
		sobra[2] = sobra[1]-867123.01;
		sobra[3] = (sobra[2]*25)/100;
		sobra[4] = sobra[3]+76652;
		isr = (sobra[4]/12);
	}
	final = (sobra[0]+bono+hr_extra-isr);
	cout << "\n";
	cout << "SUELDO  ------------ " << sueldo << endl;
	cout << "AFP ---------------- " << a << endl;
	cout << "SFS ---------------- " << b << endl;
	cout << "Otros Desc --------- " << deuda << endl;
	cout << "Horas Ext ---------- " << hr_extra << endl;
	cout << "ISR ---------------- " << int(isr) << endl;
	cout << "Sueldo NETO -------- " << int(final) << endl;
	return 0;
}

