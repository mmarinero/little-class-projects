;transforma un numero en un ascii y lo imprime, añade un espacio al final
;Parametro entrada 1: Numero que se va a imprimir por pantalla
;Parametro salida 1: Devuelve el numero de caracteres imprimidos incluyendo - y un espacio
%define numero ebp + 8
%define longMaxima 12 ;Suficiente para 32 bits
segment .text
global ver_num
extern ver_cadena

ver_num:

    enter 20,0
    pusha
    mov eax, [numero]
    mov esi, 0 ;bandera negativo
    mov byte [ebp-1], 0x20; ponemos un espacio al final
    mov ecx, -2 ;contador para imprimir desde la posicion correcta
    cmp dword [numero], 0 ;comprobar signo
    jge bucle
    neg eax
    mov esi, 1
bucle:
    mov edx, 0 
    mov ebx, 10
    div ebx ;en el resto queda el digito menos significativo
    add dl, '0' ;contruir el ascii
    mov byte [ebp+ecx], dl
    dec ecx
    cmp eax, 0
    jnz bucle

    cmp esi, 0 ;poner el signo '-' delante
    je noNegativo
    mov byte [ebp+ecx], '-'
    dec ecx
noNegativo:
    inc ecx
    lea eax, [ebp+ecx]
    push eax
    neg ecx
    push ecx
    call ver_cadena
    add esp, 8
    mov dword [numero], ecx
    popa
    leave
    ret
