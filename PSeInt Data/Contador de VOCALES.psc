Algoritmo Contador_De_Vocales
	Leer p
	para i<-1 Hasta Longitud(p) Hacer
		L<-Subcadena(p,i,i)
		si L='a' Entonces
			c=c+1
		Sino
			si L='e' Entonces
				c1=c1+1
			Sino
				si L='i' Entonces
					c2=c2+1
				Sino
					si L='o' Entonces
						c3=c3+1
					Sino
						si L='u' Entonces
							c4=c4+1
						FinSi
					FinSi
				FinSi
			FinSi
		FinSi
	FinPara
	Escribir 'En a hay ' c
	Escribir 'En e hay ' c1
	Escribir 'En i hay ' c2
	Escribir 'En o hay ' c3
	Escribir 'En u hay ' c4
FinAlgoritmo
