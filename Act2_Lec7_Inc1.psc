Algoritmo Buzon_de_voz
	Escribir "===MENSAJE DE VOZ==="
	Definir opc Como Entero
	Escribir "Menu principal"
	Escribir "1- Recepcion"
	Escribir "2- Contabilidad"
	Escribir "3- Mantenimiento"
	Escribir "4- Salir"
	Escribir Sin Saltar "Digite una opcion: "
	leer opc
	si (opc == 1) Entonces
			Escribir "Bienvenido al Departamento Recepcion"
	FinSi
	si (opc == 2) Entonces
			Escribir "Bienvenido al Departamento Contabilidad"
	FinSi
	si (opc == 3) Entonces
			Escribir "Bienvenido al Departamento Mantenimiento"
	FinSi
	si (opc <> 1 y opc <> 2 y opc <> 3) Entonces
		Escribir "Salir del Sistema!"
	FinSi	
FinAlgoritmo
