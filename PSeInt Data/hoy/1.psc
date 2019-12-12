Proceso sin_titulo
	Repetir
		Escribir 'Escoja las opciones (1)Suma, (2)Sacar 15%, (3)Realizar Tabla de un Numero cualquiera (4)Determinar usuario mayor de edad (5)Realizar la Suma, Resta, Div, Mult, de dos numeros (6)Para Salir'
		Escribir ''
		Leer Opcion
		Escribir ''
		Segun Opcion  Hacer
			1:
				Escribir 'Dijite los # a sumar'
				Leer A,B
				C<-A+B
				Escribir 'El resultado es ',C
			2:
				Escribir 'Ingrese el valor del producto'
				Leer A
				B<-A*15/100
				Escribir 'El 15% es ',B
			3:
				Escribir 'Escoja la tabla del numero deseado'
				Leer N
				TABLA<-0
				Repetir
					TABLA<-TABLA+1
					Resultado<-N*TABLA
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
				C<-A+B-A/B*A
				Escribir 'El resultado de ',A,'+',B,'-',A,'/',B,'*',A,' Es ',C
			6:
			De Otro Modo:
				Escribir 'Opcion no Valida'
		FinSegun
		Escribir ''
	Hasta Que Opcion=6
FinProceso

