Algoritmo sin_titulo
	Escribir 'CALIFICACION'
	Escribir ''
	Escribir 'Nota del primer parcial con valor de 30'
	Leer NOTA1
	Escribir 'Nota del segundo parcial con valor de 30'
	Leer NOTA2
	Escribir 'Nota del tercer parcial con valor de 40'
	Leer NOTA3 
	A<-90
	B<-80
	C<-70
	D<-60
	F<-59
	NotaF<-NOTA1+NOTA2+NOTA3
	Escribir NotaF
	Si NotaF>=A y NotaF<100 Entonces
		Escribir 'A'
	Sino
		Si NotaF>=B y NotaF<=89 Entonces
			Escribir 'B'
		Sino
			Si NotaF>=C y NotaF<=79 Entonces
				Escribir 'C'
	        Sino
				Si NotaF>=D y NotaF<=69 Entonces
					Escribir 'D'
				Sino
					Si NotaF<=F Entonces
						Escribir 'F'
					Sino
						Si NotaF>100 Entonces
							Escribir 'Exedio la calificacion pedida'
						FinSi
					FinSi
				FinSi
			FinSi
		FinSi
	FinSi
FinAlgoritmo
