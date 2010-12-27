;lee un numero por teclado y lo devuelve en eax 32 bits maximo
;no comprueba errores
;parametros de entrada y salida en la pila
;sin parametros de entrada
;parametro salida 1: resultado
%define resultado ebp + 8
%define cadena ebp - 80
%define longMaxima 80
%define LF 10
segment .text
global teclado:

teclado:
    enter longMaxima,0
    pusha
    mov eax, 3
    mov ebx, 0
    lea ecx, [cadena]
    mov edx, longMaxima
    int 80h
    
    mov ecx, eax ;indice bucle +1 por el fin de linea
    dec ecx
    xor edx, edx
    xor eax, eax
    lea esi, [cadena]
    cld ;esi se utilizara para recorrer la cadena
    cmp byte [cadena], '-' ;comprobar negativo
    jnz bucle
    inc esi
    dec ecx
bucle:
    imul edx, 10 ;el resultado se almacena en edx:eax pero solo se devolvera eax
    sub byte [esi], '0'    ;transforma numero ascii en binario
    lodsb ;no hay que extender el signo a eax, siempre positivo
    add edx, eax
    loop bucle
    
    mov eax, edx
    cmp byte [cadena], '-';negar resultado si es negativo
    jnz salir
    neg eax
salir:
    mov dword [resultado], eax ;se guarda para que no se pierda con popa
    popa
    leave
    ret
