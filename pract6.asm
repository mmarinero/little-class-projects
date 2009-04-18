;El programa calcula el area de un triangulo de lados a,b,c
;emplea la formula Area=[s(s-a)(s-b)(s-c)]^0.5 con s=s(a+b+c)
;Devuelve por pantalla el area
;Se usan las funciones printf y scanf de c para recibir e imprimir los datos


segment .data
msgPedirDatos db "Introduzca los tres lados del triangulo\n",0
fRecogerDatos db "%lf"
fResultado db "Area triangulo: %lf\n",0 

segment .bss


segment .text
global pract6
extern printf, scanf

pract6:
    enter 0,0
    pusha

    popa
    leave
    ret
