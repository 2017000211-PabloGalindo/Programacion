Algoritmo PromedioNotas
	Definir n1, n2, n3, n4, n5, prom, promedio Como Entero
	Escribir "Digite la materia"
	Escribir "Ingrese nota 1"
	leer n1
	Escribir "Ingrese nota 2"
	leer n2
	Escribir "Ingrese nota 3"
	leer n3
	Escribir "Ingrese nota 4"
	leer n4
	Escribir "Ingrese nota 5"
	leer n5
	prom=n1+n2+n3+n4+n5
	promedio=prom/5
	Escribir promedio
	si (promedio>=70) Entonces
		Escribir "Alumno Aprobado"
	SiNo
		Escribir "Alumno Reprobado"
	FinSi
FinAlgoritmo
