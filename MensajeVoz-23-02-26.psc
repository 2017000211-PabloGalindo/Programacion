//Problema: un programa que muestre un mensaje de voz
//Crear un menu -1 Recepcion
//2- Vigilancia
//3- Mantenimiento
//4- salir o error
Algoritmo MensajeVoz
	Escribir "===MENSAJE DE VOZ==="
	//Variables
	Definir opc Como Entero
	//Menu
	Escribir "Menu principal"
	Escribir "1- Recepcion"
	Escribir "2- Vigilancia"
	Escribir "3- Mantenimiento"
	Escribir "4- Salir"
	Escribir Sin Saltar "Digite una opcion: "
	leer opc
	//Condiciones
	si (opc == 1) Entonces
		Escribir "Bienvenido al Departamento Recepcion"
		Escribir "Presione una tecla para salir"
		Esperar Tecla
		Limpiar Pantalla
		Esperar 3 Segundos
	FinSi
	si (opc == 2) Entonces
		Escribir "Bienvenido al Departamento Vigilancia"
		Escribir "Presione una tecla para salir"
		Esperar Tecla
		Limpiar Pantalla
		Esperar 3 Segundos
	FinSi
	si (opc == 3) Entonces
		Escribir "Bienvenido al Departamento Mantenimiento"
		Escribir "Presione una tecla para salir"
		Esperar Tecla
		Limpiar Pantalla
		Esperar 3 Segundos
	FinSi
	si (opc <> 1 y opc <> 2 y opc <> 3) Entonces
		Escribir "Salir del Sistema"
		Escribir "Presione una tecla para salir"
		Esperar Tecla
		Limpiar Pantalla
		Esperar 3 Segundos
	FinSi
FinAlgoritmo
