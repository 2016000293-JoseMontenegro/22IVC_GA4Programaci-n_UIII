Algoritmo Lecc35_Act1_Inc3
	Definir usuario, computadora Como Entero
	Definir respuesta, opcionUsuario, opcionComputadora Como Cadena
	Escribir 'Nombre: José Montenegro'
	Escribir 'Grado: IVC - Clave = 22'
	Escribir '=====JUEGO===='
	Repetir
		Escribir '1. Piedra'
		Escribir '2. Papel'
		Escribir '3. Tijeras'
		Leer usuario
		computadora <- Aleatorio(1,3)
		Según usuario Hacer
			1:
				opcionUsuario <- 'Piedra'
			2:
				opcionUsuario <- 'Papel'
			3:
				opcionUsuario <- 'Tijeras'
		FinSegún
		Según computadora Hacer
			1:
				opcionComputadora <- 'Piedra'
			2:
				opcionComputadora <- 'Papel'
			3:
				opcionComputadora <- 'Tijeras'
		FinSegún
		Escribir 'Usuario: ', opcionUsuario
		Escribir 'Computadora: ', opcionComputadora
		Si usuario=computadora Entonces
			Escribir 'Empate'
		SiNo
			Si (usuario=1 Y computadora=3) O (usuario=2 Y computadora=1) O (usuario=3 Y computadora=2) Entonces
				Escribir 'Usted gano'
			SiNo
				Escribir 'Gano la computadora'
			FinSi
			Escribir 'Desea jugar otra vez (s/n):'
			Leer respuesta
			respuesta <- Minusculas(respuesta)
		FinSi
	Hasta Que respuesta='n'
FinAlgoritmo
