Algoritmo sin_titulo
	Repetir
		Escribir 'Escoja la Opcion Deseada'
		Escribir ''
		Escribir '(1)Suma'
		Escribir '(2)Sacar 15% de un producto'
		Escribir '(3)Realizar tabla numerica de cualquier numero'
		Escribir '(4)Determinar si el usuario es mayor de edad'
		Escribir '(5)Realizar la Suma, Resta, Div, Mult, de dos numeros'
		Escribir '(6)Para contar vocales'
		Escribir '(7)Para salir del programa'
		Escribir ''
		Leer Opcion
		Escribir ''
		Segun Opcion  Hacer
			1:
				Escribir 'Dijite los # a sumar'
				Leer A,B
				c <- A+B
				Escribir 'El resultado es ',c
			2:
				Escribir 'Ingrese el valor del producto'
				Leer A
				B <- A*15/100
				Escribir 'El 15% es ',B
			3:
				Escribir 'Escoja la tabla del numero deseado'
				Leer N
				TABLA <- 0
				Repetir
					TABLA <- TABLA+1
					Resultado <- N*TABLA
					Escribir N,'*',TABLA,'= ',Resultado
				Hasta Que TABLA=12
			4:
				Escribir 'Digiar la edad del usuario'
				Leer A
				Si A>18 Entonces
					Escribir 'Es mayor de edad'
				Sino
					Escribir 'Es menor de edad'
				FinSi
			5:
				Escribir 'Dijite dos #'
				Leer A,B
				R1 <- A+B
				R2 <- A-B
				R3 <- A/B
				R4 <- A*B
				Escribir 'El resultado de la Suma es ',R1
				Escribir 'El resultado de la Resta es ',R2
				Escribir 'El resultado de la Division es ',R3
				Escribir 'El resultado de la Multiplicacion es ',R4
			6:
				Escribir 'Ingrese una oracion'
				Leer P
				Para i<-1 Hasta Longitud(P) Hacer
					L <- Subcadena(P,i,i)
					Si L='a' Entonces
						cc <- c+1
					Sino
						Si L='e' Entonces
							c1 <- c1+1
						Sino
							Si L='i' Entonces
								c2 <- c2+1
							Sino
								Si L='o' Entonces
									c3 <- c3+1
								Sino
									Si L='u' Entonces
										c4 <- c4+1
									FinSi
								FinSi
							FinSi
						FinSi
					FinSi
				FinPara
				Escribir 'En a hay ',c
				Escribir 'En e hay ',c1
				Escribir 'En i hay ',c2
				Escribir 'En o hay ',c3
				Escribir 'En u hay ',c4
			7:
			De Otro Modo:
				Escribir 'Opcion no Valida'
		FinSegun
		Escribir ''
	Hasta Que Opcion=7
FinAlgoritmo

