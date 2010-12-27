;Programa que multiplica con el algoritmo de solapamiento de ternas.
;Y divide con el algorimo de division sin restauracion.
;Las funciones empleadas preservan todos los registros y devuelven parametros
;por la pila, los parametros se numeran inversamente a como se meten en la pila
;el programa que llama es el que apila y desapila los parametros.

segment .data
msgPNumero db "Introduzca un numero",10
longPNumero equ $-msgPNumero
msgSNumero db "Introduzca otro numero",10
longSNumero equ $-msgSNumero
msgSeleccion db "Seleccione una opcion", 10, "1.- Multiplicacion   2.- Division", 10
longSeleccion equ $-msgSeleccion
msgResultado db 10,"Resultado: "
longMsgResultado equ $-msgResultado
fLinea db 10
longFLinea equ 1

segment .text
global _start, ver_bin
extern ver_num, ver_cadena, teclado, multiplica, divide
_start:
    ;
    ;Pedir datos por pantalla y almacenarlos en eax y ebx
    ;
    push msgPNumero
    push longPNumero
    call ver_cadena
    pop eax ;la función teclado necesita un parametro vacio 
    call teclado
    pop eax
    push msgSNumero
    push longSNumero
    call ver_cadena
    pop ebx
    call teclado
    pop ebx
    push msgSeleccion
    push longSeleccion
    call ver_cadena
    pop edx
    call teclado
    pop edx
    ;
    ;Seleccionar rutina de multiplicacion o division
    ;
    cmp edx, 1
    jne dividir
    push ebx
    push eax
    call multiplica
    jmp impResultado
dividir:
    push ebx
    push eax
    call divide
impResultado:
    pop eax 
    push msgResultado
    push longMsgResultado
    call ver_cadena
    add esp, 8
    call ver_num ;el resultado esta ya apilado
    push fLinea
    push longFLinea
    call ver_cadena
    add esp, 12
    ;
    ;salir
    ;
    mov eax, 1
    mov ebx, 0
    int 80h


;lo logico seria poner esta funcion en un nuevo fichero, pero asi 
;no es necesario compilar aparte una funcion que no se pedía en la practica

;transforma un numero en un ascii y lo imprime en binario, 
;Parametro entrada 1: Numero que se va a imprimir por pantalla
%define numero ebp + 8
%define LF 10

ver_bin:

    enter 36, 0 ;espacio para 32 bits y LF
    pusha
    lea edx, [ebp - 36] ;principio memoria reservada en pila
    mov eax, [numero]
    mov ecx, 32
bucle:
    mov byte [edx], 0x18 ;0x30/2
    shl eax, 1
    rcl byte [edx],1 ;0x18<<CF resulta en 0x31 o 0x30 como se necesita
    inc edx
    loop bucle

    mov byte [edx], 0x20 ;se añade el espacio
    lea eax, [ebp-36]
    push eax
    push 33;
    call ver_cadena
    add esp, 8
    popa
    leave
    ret
