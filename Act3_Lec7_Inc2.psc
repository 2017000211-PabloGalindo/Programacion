Algoritmo Triangulos
	Definir lado1, lado2, lado3 Como Entero
	Escribir "Ingresa el lado 1: "
	Leer lado1
	Escribir "Ingresa el lado 2: "
	Leer lado2
	Escribir "Ingresar el lado 3: "
	Leer lado3
	Si (lado1 == lado2) Y (lado2 == lado3) Entonces
		Escribir "El triángulo es: Equilátero"
	SiNo
		Si (lado1 == lado2) O (lado1 == lado3) O (lado2 == lado3) Entonces
			Escribir "El triángulo es: Isósceles"
		SiNo
			Escribir "El triángulo es: Escaleno"
		FinSi
	FinSi
FinAlgoritmo
