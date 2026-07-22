Algoritmo Lecc34_Act1_Inc1
	Definir opc, num, copia, residuo, i, result Como Entero
	Definir binario, digito Como Cadena
	Definir valido Como Lógico
	Escribir 'Nombre: José Montenegro'
	Escribir 'Grado: IVC - Clave = 22'
	Escribir '=====DECIMAL A BINARIO===='
	Escribir '1. Decimal a binario'
	Escribir '2. Binario a decimal'
	Leer opc
	Si opc=1 Entonces
		Escribir 'Ingrese un numero decimal:'
		Leer num
		Si num=0 Entonces
			Escribir 'Numero binario: 0'
		SiNo
			copia <- num
			binario <- ''
			Mientras copia>0 Hacer
				residuo <- copia MOD 2
				binario <- ConvertirATexto(residuo)+binario
				copia <- Trunc(copia/2)
			FinMientras
			Escribir 'Numero binario: ', binario
		FinSi
	SiNo
		Si opc=2 Entonces
			Escribir 'Ingrese un numero binario:'
			Leer binario
			result <- 0
			valido <- Verdadero
			Para i<-0 Hasta Longitud(binario)-1 Con Paso 1 Hacer
				digito <- Subcadena(binario,i,i)
				Si digito<>'0' Y digito<>'1' Entonces
					valido <- Falso
				SiNo
					result <- result*2+ConvertirANumero(digito)
				FinSi
			FinPara
			Si valido Entonces
				Escribir 'Numero decimal: ', result
			SiNo
				Escribir 'Numero binario invalido'
			FinSi
		SiNo
			Escribir 'Opcion invalida'
		FinSi
	FinSi
FinAlgoritmo
