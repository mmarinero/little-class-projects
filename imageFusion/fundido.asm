;Funcion que funde las matrices de dos imagenes empleando instrucciones mmx
;el valor de fundido debe ser 1
;La longituda marca las veces que se ejecuta el bucle procesando
;4 pixels cada vez

segment .text
global fundido

fundido:
    enter 8,0
    pusha
    mov ecx, [ebp+8] ;longitud
    mov eax, [ebp+12] ;direccion m1
    mov ebx, [ebp+16] ;direccion m2
    mov edx, [ebp+20] ;vFundido
    cmp edx, 0x80 ;valor maximo para fundido correcto
    jle sininvertir
    neg edx
    add edx, 0x100 ;edx 256-vfundido, mas correcto que 255-vfundido
    xchg eax, ebx ;intercambiar punteros matrices
sininvertir:
    mov [ebp-2], dx
    mov [ebp-4], dx
    mov [ebp-6], dx
    mov [ebp-8], dx
    movq mm3, [ebp-8] ;vFundido 4 veces operar con palabras 
    mov edx, [ebp+12] ;m1 es el destino de la imagen
    xor esi, esi
    movd mm0, esi; mm0=0
bucle: ;se ejecutara 4 veces a la vez (vf*(Bm1-Bm2)>>8)+Bm2
    movd mm1, [eax+4*esi]   ;4 bytes de m1
    movd mm2, [ebx+4*esi]   ;4 bytes de m2
    punpcklbw  mm1, mm0	    ;colocar bytes: 1 palabra por byte
    punpcklbw  mm2, mm0	    ;colocar bytes: 1 palabra por byte
    psubw mm1, mm2	    ;restar bytes  m1 - bytes m2
    pmullw mm1, mm3	    ;vFundido *(bm1 -bm2)=16 bits no hay overflow
    psraw mm1, 8	    ;obtener byte mas significativo
    paddw mm1, mm2	    ;(vf*(Bm1-Bm2)>>8)+Bm2
    packuswb mm1, mm0	    ;colocar 4 bytes resultado posiciones bajas mm1
    movd dword [edx+4*esi], mm1 ;escribir 4 bytes sobre memoria de m1
    inc esi
    loop bucle

    popa
    mov eax, [ebp+12] ;retornar puntero a m1
    leave
    ret
