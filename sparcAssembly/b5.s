LF=10
MAX=79
UL='a'-'A'
	.data
mensaje:.ascii "¿PORQUE NO TE CALLAS?"
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
	mov MAX, %o1
	call lee_cadena
	nop

/*convierte a mayusculas*/
	call toupper
	nop
/*convierte cadena en hezadecimal binario	
	call tobin
	nop
/*Impresion de la cadena*/

	call imprime_cadena
	nop
	mov LF, %o0
	call putchar
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
	be salto
	nop
	cmp%i1,%l1
	bne bucle1
salto:
	inc%l1
	dec%l1
	stb%g0,[%i0+%l1]
	mov%l1,%i1
	ret
	restore




toupper:

	save%sp,-64,%sp
	mov%i1,%l1
bucle2:
	dec%l1
	ldub [%i0+%l1], %o0
	cmp%o0,'a'
	bl ignorar	
	cmp%o0,'z'
	be ignorar
	nop
	dec UL,%o0
	stb%o0,[%i0+%l1]
ignorar:
	cmp%g0,%l1
	bne bucle2
	nop
	ret
	restore


tobin:
	
	save%sp,-64,%sp
	ldub [%i0+%l1	






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
