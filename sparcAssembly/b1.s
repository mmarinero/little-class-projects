LF=10
	.data
mensaje:.ascii "Introduczca una cadena: "
L=.- mensaje
cadena: .skip 80
	.text
	.global main

main:
	save%sp,-64,%sp
/*Impresión del mensaje*/
	set mensaje,%o0

	mov L, %o1
	call imprime_cadena
	nop
/*Lectura de la cadena */
	call lee_cadena
	nop

/*Impresion de la cadena*/

	call imprime_cadena
	nop
	ret
	restore
lee_cadena:

	save%sp, -64,%sp
	clr%l1

	set cadena,%i0
bucle1:
	call getchar
	nop
	stb%o0,[%i0+%l1]
	cmp%o0,LF
	bne bucle1
	inc%l1
	mov%l1,%i1
	ret
	restore

imprime_cadena:

	save%sp, -64,%sp
	clr%l1
bucle:
	ldub [%i0 +%l1], %o0
	call putchar
	inc%l1
	deccc%i1
	bne bucle
	nop
	ret
	restore
