Algoritmo Día_Semana
	Definir dia Como Entero
	Escribir "Ingresa un numero de la semana (1-7):"
	Leer dia
	Si (dia == 6) O (dia == 7) Entonces
		Escribir "FIN DE SEMANA"
	SiNo
		Si (dia >= 1) y (dia <= 5) Entonces
			Escribir "ENTRE SEMANA"
		SiNo
			Escribir "NUMERO NO VALIDO"
		FinSi
	FinSi
FinAlgoritmo
