Algoritmo sin_titulo
	Escribir 'Prueba de Segun'
	Escribir  ''
	Escribir 'Escoja una opcion'
	Escribir '(1)Suma (2)Resta (3)Multiplicacion (4)Division'
	Leer x
	Segun x Hacer
		1:
			Escribir 'Ponga un #'
			Leer S1
			Escribir 'Ponga un #'
			Leer S2
			S3<-S1+S2
			Escribir 'El resultado es ' S3
		2:
			Escribir 'Ponga un #'
			Leer R1
			Escribir 'Ponga un #'
			Leer R2
			R3<-R1-R2
			Escribir 'El resultado es ' R3
		3:
			Escribir 'Ponga un #'
			Leer M1
			Escribir 'Ponga un #'
			Leer M2
			M3<-M1*M2
			Escribir 'El resultado es ' M3
		4:
			Escribir 'Ponga un #'
			Leer D1
			Escribir 'Ponga un #'
			Leer D2
			D3<-D1/D2
			Escribir 'El resultado es ' D3
		De Otro Modo:
			Escribir 'Operacion Incorrecta'
	Fin Segun
	
	FinAlgoritmo
